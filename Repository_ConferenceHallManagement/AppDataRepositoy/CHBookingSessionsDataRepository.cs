using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConferenceHallManagement.AppDataRepositoy
{
    public interface ICHBookingSessionsDataRepository : IRepository<ConferenceHallBookingSession>
    {
        Task<ConferenceHallBookingSession?> GetConferenceHallSessionBookingDetails(int hallId, int sessionId, DateTime bookingDate);
        Task<IEnumerable<ConferenceHallBookingSession>?> GetConferenceHallSessionBookingDetailsByBookingId(int bookingId);
    }
    public class CHBookingSessionsDataRepository : Repository<ConferenceHallBookingSession>, ICHBookingSessionsDataRepository
    {
        public CHBookingSessionsDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }
        public async Task<ConferenceHallBookingSession?> GetConferenceHallSessionBookingDetails(int hallId, int sessionId, DateTime bookingDate)
        {
            return await _context.ConferenceHallBookingSessions.FirstOrDefaultAsync(x => (x.Status == 2 || x.Status == 5) && x.HallId == hallId && x.SessionId == sessionId && x.BookingDate.Date == bookingDate.Date);

        }
        public async Task<IEnumerable<ConferenceHallBookingSession>?> GetConferenceHallSessionBookingDetailsByBookingId(int bookingId)
        {
            return await _context.ConferenceHallBookingSessions.Where(x => x.BookingId == bookingId && x.Status != 3 && x.Status != 4).ToListAsync();

        }
    }
}
