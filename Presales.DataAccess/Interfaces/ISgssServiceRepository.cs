using Presales.Entity;

namespace Presales.DataAccess.Interfaces
{
    public interface ISgssServiceRepository

    {
        // Récupérer tous les services déja souscrit
        Task<IEnumerable<SgssService>> GetAllSgssServiceAlready();

        // Récuperer un service déja souscrit par un client à l'aide de deux clés primaire
        Task<SgssService> GetSgssServiceAlreadyProvided( long Idbdr, long IdService);

        // Ajouter un nouveau service soucrit par un client
        Task<SgssService> Add(SgssService sgssServiceAlreadyProvided);

        // Mettre à jour un Service
        Task<SgssService> Update(SgssService sgssServiceAlreadyProvided);

        // Supprimer un service souscrit par un client à l'aide de deux clés primaire
        Task<ClientSgssService> Delete(long Idbdr, long IdService);

    }
}
