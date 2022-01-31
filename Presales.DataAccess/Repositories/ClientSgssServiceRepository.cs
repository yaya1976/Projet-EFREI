using Microsoft.EntityFrameworkCore;
using Presales.DataAccess.Context;
using Presales.DataAccess.Interfaces;
using Presales.Entity;

namespace Presales.DataAccess.Repositories
{
    public class ClientSgssServiceRepository : IClientSgssServiceRepository
    {
        // creation d'une variable presalesContext
        private readonly PresalesContext _presalesContext;

        // constructeur 
        public ClientSgssServiceRepository(PresalesContext presalesContext)

        {
            _presalesContext = presalesContext;
        }
        async Task<ClientSgssService> IClientSgssServiceRepository.Add(ClientSgssService clientSgssService)

        {
            await _presalesContext.ClientSgssServices.AddAsync(clientSgssService);
            await _presalesContext.SaveChangesAsync();
            return clientSgssService;
        }

        Task<ClientSgssService> IClientSgssServiceRepository.Delete(long IdService)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<ClientSgssService>> IClientSgssServiceRepository.GetAllListOfSgssServices()
        {
            return await _presalesContext.ClientSgssServices.ToListAsync();
        }

        async Task<ClientSgssService> IClientSgssServiceRepository.GetListOfSgssServices(long IdService)
        {
            return await _presalesContext.ClientSgssServices.Where(c => c.IdService == IdService).FirstOrDefaultAsync();
        }

        async Task<ClientSgssService> IClientSgssServiceRepository.Update(ClientSgssService clientSgssService)

        {
            _presalesContext.ClientSgssServices.Update(clientSgssService);
            await _presalesContext.SaveChangesAsync();
            return clientSgssService;
        }
    }
}
