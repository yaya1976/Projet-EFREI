namespace Presales.Entity
{
    /// liste des services SGSS;
    public class ClientSgssService

    {
                
        // ID du Service;
        public long IdService { get; set; }

        // Name of Service;
        public string IdBdr { get; set; }

        public Client Client { get; set; }
        public SgssService SgssService { get; set; }

    }
}
