namespace Presales.Entity
{
    public class ClientAssetClass


    {
        
        public long IdBdr { get; set; }
        public long IdAssetClass { get; set; }

        public Client Client { get; set; }
        public AssetClass AssetClass { get; set; }

    }
}
