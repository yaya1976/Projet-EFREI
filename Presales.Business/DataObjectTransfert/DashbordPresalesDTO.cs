using Presales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presales.Business.DataObjectTransfert
{
    public class DashbordPresalesDTO

    {
        public long IdBdr { get; set; }
        public string Name { get; set; }
        public string ClientType { get; set; }
        public DateOnly DateLastRFP { get; set; }
        public bool SgssProspectionUniverse { get; set; }
        public string OverviewCustomerActivity { get; set; }
        public float TotalGlobalFirmAumKeur { get; set; }
        public float NumberOfFunds { get; set; }
        public string NameOfPriority { get; set; }
        public string CustomerNeedDescription { get; set; }
        public string NameClass { get; set; }
        public string NameService { get; set; }
        public string IdCountry { get; set; }
        public float TotalLocalFirmAumEur { get; set; }
        public float AmountTotalAssetCustodiedByCountry { get; set; }
        public string CompetitoresCurrentCustodiensDepositariesFundAdministrators { get; set; }
        public float AmountLocalAssetCustodiedByCometitores { get; set; }
        public string TypeOfService { get; set; }
        public string DepartementBanking { get; set; }
        public bool Outsourced { get; set; }
        public string ItSystem { get; set; }
        public DateOnly Date { get; set; }


        public static implicit operator DashbordPresalesDTO(Client client) => new DashbordPresalesDTO(client);

        //fonction de mapping 
        public DashbordPresalesDTO(Client client) 
        {
            IdBdr = client.IdBdr;
            Name = client.Name;
            ClientType = client.ClientType;
            DateLastRFP = client.DateLastRFP;
            SgssProspectionUniverse = client.SgssProspectionUniverse;
            OverviewCustomerActivity = client.OverviewCustomerActivity;
            TotalGlobalFirmAumKeur = client.TotalGlobalFirmAumKeur;
            NumberOfFunds = client.NumberOfFunds;
            NameOfPriority = client.NameOfPriority;
            CustomerNeedDescription = client.CustomerNeedDescription;
            NameClass = client.NameClass;
            NameService = client.NameService;
            IdCountry = client.IdCountry;
            TotalLocalFirmAumEur = client.TotalGlobalFirmAumKeur;
            AmountTotalAssetCustodiedByCountry = client.AmountTotalAssetCustotiedByCountry;
            CompetitoresCurrentCustodiensDepositariesFundAdministrators = client.Compe;
            AmountLocalAssetCustodiedByCometitores = client.AmountLocalAssetCustodiedByCometitores;
            TypeOfService = client.TypeOfService;
            DepartementBanking = client.DepartementBanking;
            Outsourced = client.Outsourced;
            ItSystem = client.ItSystem;
            Date = client.Date;



            




        }
    }
   
}
