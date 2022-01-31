namespace Presales.Entity
{
    //customer priority
    public class Priority

    {
        /// Priorite Client;
        
        // Identifiant Priorite
        public long IdPriority { get; set; }

        // Nom de la priorite : High, Medium, low;
        public string NameOfPriority { get; set; }

        // description du besoin du client;
        public string CustomerNeedDescription { get; set; }

        public ICollection<ClientPriority> ClientPriorities { get; set; }


    }
}
