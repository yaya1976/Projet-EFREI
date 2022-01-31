using Microsoft.EntityFrameworkCore;
using Presales.DataAccess.Context;
using Presales.DataAccess.Interfaces;
using Presales.Entity;

namespace Presales.DataAccess.Repositories
{
    public class ClientLocalAumRepository : IClientLocalAumRepository
    {
        // creation d'une variable presalesContext
        private readonly PresalesContext _presalesContext;

        // constructeur 
        public ClientLocalAumRepository(PresalesContext presalesContext)
        {
            _presalesContext = presalesContext;
        }

        async Task<ClientLocalAum> IClientLocalAumRepository.Add(ClientLocalAum localAum)
        {
            await _presalesContext.ClientLocalAums.AddAsync(localAum);
            await _presalesContext.SaveChangesAsync();
            return localAum;
        }

        Task<ClientLocalAum> IClientLocalAumRepository.Delete(long Idbdr, long IdLocalAum)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<ClientLocalAum>> IClientLocalAumRepository.GetAllLocalAssetManagedCustodied()
        {
            return await _presalesContext.ClientLocalAums.ToListAsync();
        }

        async Task<ClientLocalAum> IClientLocalAumRepository.GetLocalAssetManagedCustodied(long Idbdr, long IdLocalAum)
        {
            return await _presalesContext.ClientLocalAums.Where(c => c.IdLocalAum == IdLocalAum).FirstOrDefaultAsync();
        }

        async Task<ClientLocalAum> IClientLocalAumRepository.Update(ClientLocalAum localAum)
        {
            _presalesContext.ClientLocalAums.Update(localAum);
            await _presalesContext.SaveChangesAsync();
            return localAum;
        }
    }
}

