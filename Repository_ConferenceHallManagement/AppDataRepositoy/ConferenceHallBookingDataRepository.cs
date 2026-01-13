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
    public interface IConferenceHallBookingDataRepository : IRepository<ConferenceHallBooking>
    {
    }
    public class ConferenceHallBookingDataRepository : Repository<ConferenceHallBooking>, IConferenceHallBookingDataRepository
    {
        public ConferenceHallBookingDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }
        
        public override async Task<IEnumerable<ConferenceHallBooking>> GetAllAysnc()
        {
            return await _context.ConferenceHallBookings
                .Include(x=>x.Hall)
                .Include(x=>x.RoomType)
                .Include(x=>x.StatusNavigation)
                .Include(x => x.ConferenceHallBookingSessions)
                    .ThenInclude(x => x.Session)
                .Include(x => x.ConferenceHallBookingSessions)
                    .ThenInclude(x => x.StatusNavigation)
                .ToListAsync();
        }
        public override async Task<ConferenceHallBooking?> GetByIdAysnc(int id)
        {
            return await _context.ConferenceHallBookings
                .Include(x => x.Hall)
                .Include(x => x.RoomType)
                .Include(x => x.StatusNavigation)
                .Include(x => x.ConferenceHallBookingSessions)
                    .ThenInclude(x => x.Session)
                .Include(x => x.ConferenceHallBookingSessions)
                    .ThenInclude(x => x.StatusNavigation)
                .FirstOrDefaultAsync(x=>x.BookingId == id);
        }
    }
}
