using Microsoft.EntityFrameworkCore;
using Presales.DataAccess.Context;
using Presales.DataAccess.Interfaces;
using Presales.Entity;

namespace Presales.DataAccess.Repositories
{
    public class SgssServiceAlreadyProvided : ISgssServiceRepository

    {

        // creation d'une variable presalesContext
        private readonly PresalesContext _presalesContext;

        // constructeur 
        public SgssServiceAlreadyProvided(PresalesContext presalesContext)
        {
            _presalesContext = presalesContext;
        }

        async Task<Entity.SgssService> ISgssServiceRepository.Add(Entity.SgssService sgssServiceAlreadyProvided)
        {
            await _presalesContext.SgssServices.AddAsync(sgssServiceAlreadyProvided);
            await _presalesContext.SaveChangesAsync();
            return sgssServiceAlreadyProvided;
        }

        Task<ClientSgssService> ISgssServiceRepository.Delete(long Idbdr, long IdService)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Entity.SgssService>> ISgssServiceRepository.GetAllSgssServiceAlready()
        {
            return await _presalesContext.SgssServices.ToListAsync();
        }

        async Task<Entity.SgssService> ISgssServiceRepository.GetSgssServiceAlreadyProvided(long Idbdr, long IdService)
        {
            return await _presalesContext.SgssServices.Where(c => c.IdService == IdService).FirstOrDefaultAsync();
        }

        async Task<Entity.SgssService> ISgssServiceRepository.Update(Entity.SgssService sgssServiceAlreadyProvided)
        {
            _presalesContext.SgssServices.Update(sgssServiceAlreadyProvided);
            await _presalesContext.SaveChangesAsync();
            return sgssServiceAlreadyProvided;
        }
    }
}
