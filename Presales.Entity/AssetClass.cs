namespace Presales.Entity
{
    /// Nom des assets gérés par le client;
    public class AssetClass

    {
                
        // ID de l'asset class;
        public long IdAssetClass { get; set; }

        // nom de l'asset class;
        public string NameClass { get; set; }

        // propriete de navigation que l'on doit mettre dans la classe pour refleter l'association entre deux tables
        public ICollection<ClientAssetClass> ClientAssetClass { get; set; }

    }



}
