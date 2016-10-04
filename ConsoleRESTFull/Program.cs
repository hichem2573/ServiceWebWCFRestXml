using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleRESTFull
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://localhost:5000/ServiceGeo/Pays", UriKind.Absolute));
            Console.In.Read();
        }

        private static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.Out.WriteLine(e.Result);
            string str = e.Result;

            XElement xml = XElement.Parse(str);
            XNamespace ns = "http://schemas.microsoft.com/2003/10/Serialization/Arrays";

            var noms = from p in xml.Elements(ns + "string") select p.Value;
            foreach(string nom in noms)
            {
                Console.Out.WriteLine(nom);
            }
        }
    }
}
