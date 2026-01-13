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
    public interface IMasterBookingStatusDataRepository : IRepository<MasterBookingStatusCode>
    {
        // Define methods for managing master booking status data
        //Task<int> AddMasterBookingStatus(MasterBookingStatusCode status);
        //Task<int> UpdateMasterBookingStatus(MasterBookingStatusCode status);
        //Task<MasterBookingStatusCode> GetMasterBookingStatusById(int statusId);
        //Task<IEnumerable<MasterBookingStatusCode>> GetAllMasterBookingStatuses();
        Task<MasterBookingStatusCode> GetMasterBookingStatusByStatusId(int statusId);
        Task<IEnumerable<MasterBookingStatusCode>> SearchAsync(string searchTerm);
    }
    public class MasterBookingStatusDataRepository : Repository<MasterBookingStatusCode>, IMasterBookingStatusDataRepository
    {
        public MasterBookingStatusDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }
        //private readonly ConferenceHallManagementContext _db;

        //public MasterBookingStatusDataRepository(ConferenceHallManagementContext db)
        //{
        //    _db = db;
        //}
        //public async Task<int> AddMasterBookingStatus(MasterBookingStatusCode status)
        //{
        //    if (status == null)
        //    {
        //        throw new ArgumentNullException(nameof(status), "Master booking status cannot be null");
        //    }
        //    await _db.MasterBookingStatusCodes.AddAsync(status);
        //    await _db.SaveChangesAsync();
        //    return status.Id; // Return the ID of the newly added status
        //}               

        //public async Task<IEnumerable<MasterBookingStatusCode>> GetAllMasterBookingStatuses()
        //{
        //    return await _db.MasterBookingStatusCodes.Where(x=>x.Status == true).ToListAsync(); // Return all master booking statuses
        //}

        public async Task<MasterBookingStatusCode> GetMasterBookingStatusByStatusId(int statusId)
        {
            var status = await _context.MasterBookingStatusCodes.FirstOrDefaultAsync(x=>x.MasterBookingStatusId == statusId);
            if (status == null)
            {
                throw new KeyNotFoundException($"Master booking status with ID {statusId} not found.");
            }
            return status; // Return the master booking status by ID
        }

        public async Task<IEnumerable<MasterBookingStatusCode>> SearchAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await _context.MasterBookingStatusCodes
                    .Where(x => x.Status == true)
                    .OrderByDescending(x => x.Id)
                    .ToListAsync();
            }

            searchTerm = searchTerm.ToLower().Trim();

            return await _context.MasterBookingStatusCodes
                .Where(x => x.Status == true && 
                    (x.StatusTextEn.ToLower().Contains(searchTerm) || 
                     x.StatusTextHi.ToLower().Contains(searchTerm) ||
                     x.MasterBookingStatusId.ToString().Contains(searchTerm)))
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        //public async Task<int> UpdateMasterBookingStatus(MasterBookingStatusCode status)
        //{
        //    if (status == null)
        //    {
        //        throw new ArgumentNullException(nameof(status), "Master booking status cannot be null");
        //    }
        //    var existingStatus = await _context.MasterBookingStatusCodes.FindAsync(status.Id);
        //    if (existingStatus == null)
        //    {
        //        throw new KeyNotFoundException($"Master booking status with ID {status.Id} not found.");
        //    }
        //    existingStatus.StatusTextEn = status.StatusTextEn;
        //    existingStatus.StatusTextHi = status.StatusTextHi;
        //    existingStatus.Status = status.Status;
        //    existingStatus.UpdatedBy = status.UpdatedBy;
        //    existingStatus.UpdatedOn = DateTime.Now;
        //    existingStatus.UpdatedFrom = status.UpdatedFrom;
        //    await _context.SaveChangesAsync();
        //    return status.Id; // Return the ID of the updated status
        //}
    }
}
