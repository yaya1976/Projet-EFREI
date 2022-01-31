namespace Presales.Entity
{

    public class SgssService

    {
        // services SGSS Already Provided;
        public long IdBdr { get; set; }

        // ID du service;
        public long IdService { get; set; }

        // name of the service
        public string NameServie { get; set; }

        // Type of service: Provided, Targeted, Fitting;
        public string TypeOfService { get; set; }

        // ID du pays 
        public string IdCountry { get; set; }

        // Departement Banking : FO,MO,BO;
        public string DepartementBanking { get; set; }

        // Banking departement Outsourced;
        public bool Outsourced { get; set; }

        // IT System : PMS, OMS;
        public string ItSystem { get; set; }

        // Date;
        public DateOnly Date { get; set; }

        public ICollection<SgssService> sgssServices { get; set; }



    }
}
