using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;

namespace Repository_ConferenceHallManagement.AppDataRepositoy
{
    public interface ICHSessionDataRepository : IRepository<ConferenceHallSession>
    {
        Task<IEnumerable<ConferenceHallSession>> GetConferenceHallSessionByHallId(int hallId);
    }
    public class CHSessionDataRepository : Repository<ConferenceHallSession>, ICHSessionDataRepository
    {
        public CHSessionDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ConferenceHallSession>> GetConferenceHallSessionByHallId(int hallId)
        {
            return await _context.ConferenceHallSessions.Where(x => x.HallId == hallId && x.Status == true).ToListAsync();           
            
        }

    }
}
