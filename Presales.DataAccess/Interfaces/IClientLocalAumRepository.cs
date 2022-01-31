using Presales.Entity;

namespace Presales.DataAccess.Interfaces
{
    public interface IClientLocalAumRepository


    {
        // Récupérer tous les Aum
        Task<IEnumerable<ClientLocalAum>> GetAllLocalAssetManagedCustodied();

        // Récuperer un Aum 
        Task<ClientLocalAum> GetLocalAssetManagedCustodied(long Idbdr, long IdLocalAum);

        // Ajouter un Aum à un client
        Task<ClientLocalAum> Add(ClientLocalAum localAum);

        // Mettre à jour un Aum pour un client
        Task<ClientLocalAum> Update(ClientLocalAum localAum);

        // Supprimer un Aum
        Task<ClientLocalAum> Delete(long Idbdr, long IdLocalAum);



    }
}
