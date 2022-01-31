
using Microsoft.EntityFrameworkCore;
using Presales.DataAccess.Context;
using Presales.DataAccess.Interfaces;
using Presales.Entity;

namespace Presales.DataAccess.Repositories
{
    public class ClientRepository : IClientRepository

    {
        // creation d'une variable presalesContext
        private readonly PresalesContext _presalesContext;

        // constructeur 
        public ClientRepository(PresalesContext presalesContext)
        {
            _presalesContext = presalesContext;
        }


        public async Task<IEnumerable<Client>> GetAllClient()
        {
            return await _presalesContext.Clients.Include(c => c.ClientAssetClasses)
                .Include(c => c.ClientLocalAums)
                .Include(c => c.ClientSgssServices)
                .Include(c => c.ClientPriorities).ToListAsync();

        }

        public async Task<Client> GetClient(long IdBdr)
        {
            return await _presalesContext.Clients.Where(c => c.IdBdr == IdBdr).FirstOrDefaultAsync();

        }

        public async Task<Client> Add(Client client)
        {
            await _presalesContext.Clients.AddAsync(client);
            await _presalesContext.SaveChangesAsync();
            return client;
        }

        public async Task<Client> Update(Client client)
        {
            _presalesContext.Clients.Update(client);
            await _presalesContext.SaveChangesAsync();
            return client;

        }

        public Task<Client> Delete(long IdBdr)
        {
            throw new NotImplementedException();
        }
    }

}



