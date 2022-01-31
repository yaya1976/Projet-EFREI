
using Presales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presales.DataAccess.Interfaces
{
    public interface IClientRepository
    {
        // Récuperer tous les clients
        Task <IEnumerable<Client>> GetAllClient();

        // Récuperer un client avec la clé primaire IdBdr
        Task<Client> GetClient(long IdBdr);

        // Ajouter un Client
        Task <Client> Add(Client client);

        // Mettre à jour un Client
        Task <Client> Update(Client client);

        // Supprimer un Client avec la clé primaire IdBdr
        Task <Client> Delete(long IdBdr);


    }
}
