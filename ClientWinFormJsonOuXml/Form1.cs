using System;
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
        private static string requeteXml = "http://localhost:5000/ServiceGeo.svc/Pays";
        private static string requeteJson = "http://localhost:5000/ServiceGeo.svc/Pays?format=json";
        public Form1()
        {
            InitializeComponent();
        }

        private void ExcuteRequete(string requete)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri(requete, UriKind.Absolute));
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
                Invoke(new EventHandler(delegate { textBox1.Text = str; }));
            }
            else
            {
                textBox1.Text = str;
            }
        }

        private void RadioButton_ChackedChanged(object sender, EventArgs e)
        {
            if (rbtJSON.Checked)
            {
                ExcuteRequete(requeteJson);
            }
            else
            {
                ExcuteRequete(requeteXml);
            }
        }
    }
}
