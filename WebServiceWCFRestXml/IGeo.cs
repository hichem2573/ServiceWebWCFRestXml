using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceWCFRestXml
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IGeo
    {

        [OperationContract]
        [WebGet(UriTemplate = "Pays", ResponseFormat = WebMessageFormat.Json)]
        List<string> GetNomsPays();

        [OperationContract]
        [WebGet(UriTemplate = "Pays/{nom}", ResponseFormat = WebMessageFormat.Json)]
        Pays GetInfosPays(string nom);

        [OperationContract]
        [WebGet(UriTemplate = "TousLesPays", ResponseFormat = WebMessageFormat.Json)]
        List<Pays> GetTousLesPays();
        
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class Pays
    {


        [DataMember]
        public string Nom
        {
            get;
            set;
        }

        [DataMember]
        public string Capitale
        {
            get;
            set;
        }

        [DataMember]
        public double NbHabitants
        {
            get;
            set;
        }
    }
}
