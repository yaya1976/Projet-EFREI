using Presales.Entity;

namespace Presales.DataAccess.Interfaces
{
    public interface IClientSgssServiceRepository


    {
        // Récupérer tous les services Sgss
        Task<IEnumerable<ClientSgssService>> GetAllListOfSgssServices();

        // Récuperer un service à l'aide de la clé primaire IdService
        Task<ClientSgssService> GetListOfSgssServices(long IdService);

        // Ajouter un service
        Task<ClientSgssService> Add(ClientSgssService listOfSgssServices);

        // Mettre à jour un service
        Task<ClientSgssService> Update(ClientSgssService listOfSgssServices);

        // Supprimer un service à l'aide de la clé primaire IdService
        Task<ClientSgssService> Delete(long IdService);

    }
}
