using Presales.Entity;

namespace Presales.DataAccess.Interfaces
{
    public interface IPriorityRepository


    {
        // Récuperer toute les priorités 
        Task<IEnumerable<Priority>> GetAllCustomerPriority();

        // Récuperer les priorités pour un client
        Task<Priority> GetCustomerPriority(long IdBdr, long IdPriority);

        // Ajouter une priorité à un client
        Task<Priority> Add(Priority customerPriority);

        // Mettre à jour une priorité
        Task<Priority> Update(Priority customerPriority);

        // Supprimer une priorité
        Task<Priority> Delete(long IdPriority);

    }
}
