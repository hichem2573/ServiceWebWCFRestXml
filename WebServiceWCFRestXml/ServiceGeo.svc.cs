using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceWCFRestXml
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceGeo : IGeo
    {
        private List<Pays> listePays = new List<Pays>()
        {
            new Pays {Nom="France", Capitale="Paris",NbHabitants=65 },
            new Pays {Nom="Italie", Capitale="Rome",NbHabitants=60 },
            new Pays {Nom="Espagne", Capitale="Madrid",NbHabitants=45 }
        };


        /// <summary>
        /// Méthode de recupétration de la liste des pays
        /// </summary>
        /// <returns>La liste de tous les pays </returns>
        public List<string> GetNomsPays()
        {
            List<string> listeNomsPays = new List<string>();
            foreach (Pays p in listePays)
            {
                listeNomsPays.Add(p.Nom);
            }
            return listeNomsPays;
        }
        /// <summary>
        /// Méthode permettant de Récuperé les infos concernant un pays
        /// </summary>
        /// <param name="nom">Nom du pays </param>
        /// <returns>Un pays </returns>
        public Pays GetInfosPays(string nom)
        {
            foreach (Pays p in listePays)
            {
                if (p.Nom == nom)
                {
                    return p;
                }
            }
            return null;
        }

        public List<string> GetNomsPaysAsJson()
        {
            return GetNomsPays();
        }

        public Pays GetInfosPaysAsJson(string nom)
        {
            return GetInfosPays(nom);
        }

        public List<Pays> GetTousLesPaysAsJson()
        {
            return listePays;
        }

        public List<string> GetNomsPaysAsXml()
        {
            return GetNomsPays();
        }

        public Pays GetInfosPaysAsXml(string nom)
        {
            return GetInfosPays(nom);
        }

        public List<Pays> GetTousLesPaysAsXml()
        {
            return listePays;
        }
    }
}
