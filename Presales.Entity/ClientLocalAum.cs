namespace Presales.Entity
{
    // local asset managed custodied
    public class ClientLocalAum

    {
        // ID du client;
        public long IdBdr { get; set; }

        // Id local de l'AUM
        public long IdLocalAum { get; set; }

        // ID du pays;
        public string IdCountry { get; set; }

        // Total local AUM en Eur;
        public float TotalLocalFirmAumEur { get; set; }

        // montant local des asset custodied par pays;
        public float AmountTotalAssetCustodiedByCountry { get; set; }

        // Nom des concurents;
        public string CompetitoresCurrentCustodiensDepositariesFundAdministrators { get; set; }

        // montant local des assets custodied par concurents;
        public float AmountLocalAssetCustodiedByCometitores { get; set; }

        public Client Client { get; set; }





    }
}
