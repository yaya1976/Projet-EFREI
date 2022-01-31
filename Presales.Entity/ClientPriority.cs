namespace Presales.Entity
{
    public class ClientPriority

    {
      
        public long IdBdr { get; set; }
        public long IdPriority { get; set; }

        public Client Client { get; set; }
        public Priority Priority { get; set; }

       

    }
}
