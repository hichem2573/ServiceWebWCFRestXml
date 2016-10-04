﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri("http://localhost:5000/ServiceGeo.svc/Pays", UriKind.Absolute));
            req.BeginGetResponse(new AsyncCallback(fnReponse), req);
        }

        private void fnReponse(IAsyncResult ar)
        {
            HttpWebRequest req = (HttpWebRequest)ar.AsyncState;
            HttpWebResponse rep = (HttpWebResponse)req.EndGetResponse(ar);
            Stream stream = rep.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            reader.Close();
            if (InvokeRequired)
            {
                Invoke(new EventHandler(delegate { txtBoxFluxJson.Text = str; }));
            }
            else
            {
                txtBoxFluxJson.Text = str;
            }
        }
    }
}
