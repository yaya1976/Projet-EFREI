namespace Presales.Entity
{
    public class Client

    {
        /// <summary>
        // Projet Presales
        /// </summary>

        // identifiant Client IC Anywhere récuperation via API;
        public long IdBdr { get; set; }

        //nom du client
        public string Name { get; set; }

        //client type : prospect,lead,client;
        public string ClientType { get; set; }

        //Date last RFP;
        public DateOnly DateLastRFP { get; set; }

        // Client SGSS prospection universe: yes or no;
        public Boolean SgssProspectionUniverse { get; set; }

        // Client overview customer activity;
        public string OverviewCustomerActivity { get; set; }

        //Client Total Global AUM en Euro;
        public float TotalGlobalFirmAumKeur { get; set; }

        // Client nombre de fonds detenu;
        public float NumberOfFunds { get; set; }


        public ICollection<ClientPriority> ClientPriorities { get; set; }
        public ICollection<ClientAssetClass> ClientAssetClasses { get; set; }
        public ICollection<ClientLocalAum> ClientLocalAums { get; set; }
        public ICollection<ClientSgssService> ClientSgssServices { get; set; }


    }

  
}