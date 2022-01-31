using Microsoft.EntityFrameworkCore;
using Presales.DataAccess.Context;
using Presales.DataAccess.Interfaces;
using Presales.Entity;

namespace Presales.DataAccess.Repositories
{
    public class PriorityRepository : IPriorityRepository
    {

        // creation d'une variable presalesContext
        private readonly PresalesContext _presalesContext;

        // constructeur 
        public PriorityRepository(PresalesContext presalesContext)

        {
            _presalesContext = presalesContext;
        }
        async Task<Priority> IPriorityRepository.Add(Priority customerPriority)
        {
            await _presalesContext.Priorities.AddAsync(customerPriority);
            await _presalesContext.SaveChangesAsync();
            return customerPriority;
        }

        Task<Priority> IPriorityRepository.Delete(long IdPriority)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Priority>> IPriorityRepository.GetAllCustomerPriority()
        {
            return await _presalesContext.Priorities.ToListAsync();
        }

        async Task<Priority> IPriorityRepository.GetCustomerPriority(long IdBdr, long IdPriority)
        {
            return await _presalesContext.Priorities.Where(c => c.IdPriority == IdPriority).FirstOrDefaultAsync();
        }

        async Task<Priority> IPriorityRepository.Update(Priority customerPriority)
        {
            _presalesContext.Priorities.Update(customerPriority);
            await _presalesContext.SaveChangesAsync();
            return customerPriority;

        }
    }
}
