using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceRest
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IGeo
    {
        private List<Pays> listePays = new List<Pays>()
        {
            new Pays {Nom="France", Capitale="Paris",NbHabitants=65 },
            new Pays {Nom="Italie", Capitale="Rome",NbHabitants=60 },
            new Pays {Nom="Espagne", Capitale="Madrid",NbHabitants=45 }
        };

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
        /// Méthode permettant de récupéré les infos d'un pays 
        /// en passant son nom en parametre
        /// </summary>
        /// <param name="nom">Le nom du pays</param>
        /// <returns>les infos sur le pays passer en parametre</returns>
        public Pays GetInfosPays(string nom)
        {
            foreach (Pays p in listePays)
            {
                if(p.Nom == nom)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
