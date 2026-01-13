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
    public interface IMasterRoomTypeDataRepository : IRepository<MasterRoomType>
    {
        Task<MasterRoomType?> GetMasterRoomTypeByRoomTypeId(int roomTypeId);
        Task<IEnumerable<MasterRoomType>> SearchAsync(string searchTerm);
        Task<MasterRoomType?> GetByIdForUpdateAsync(int id);
    }
    public class MasterRoomTypeDataRepository : Repository<MasterRoomType>, IMasterRoomTypeDataRepository
    {
        public MasterRoomTypeDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }
                
        public async Task<MasterRoomType?> GetMasterRoomTypeByRoomTypeId(int roomTypeId)
        {
            var roomType = await _context.MasterRoomTypes.FirstOrDefaultAsync(x => x.RoomTypeId == roomTypeId);
            if (roomType == null)
            {
                throw new KeyNotFoundException($"Master room type with ID {roomTypeId} not found.");
            }
            return roomType; 
        }

        public async Task<IEnumerable<MasterRoomType>> SearchAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await _context.MasterRoomTypes
                    .Where(x => x.Status == true)
                    .OrderByDescending(x => x.Id)
                    .ToListAsync();
            }

            searchTerm = searchTerm.ToLower().Trim();

            return await _context.MasterRoomTypes
                .Where(x => x.Status == true && 
                    (x.RoomTypeEn.ToLower().Contains(searchTerm) || 
                     x.RoomTypeHi.ToLower().Contains(searchTerm) ||
                     x.RoomTypeId.ToString().Contains(searchTerm)))
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task<MasterRoomType?> GetByIdForUpdateAsync(int id)
        {
            return await _context.MasterRoomTypes.FindAsync(id);
        }
    }
}
