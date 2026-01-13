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
    public interface IMasterTempEmployeeRoleDataRepository : IRepository<TempEmployeeRole>
    {
        Task<IEnumerable<TempEmployeeRole>> SearchAsync(string searchTerm);
        Task<TempEmployeeRole?> GetByIdForUpdateAsync(int id);
    }

    public class MasterTempEmployeeRoleDataRepository : Repository<TempEmployeeRole>, IMasterTempEmployeeRoleDataRepository
    {
        public MasterTempEmployeeRoleDataRepository(ConferenceHallManagementContext context) : base(context)
        {
        }

        public async Task<IEnumerable<TempEmployeeRole>> SearchAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await _context.TempEmployeeRoles
                    .Where(x => x.Status == true)
                    .OrderByDescending(x => x.Id)
                    .ToListAsync();
            }

            searchTerm = searchTerm.ToLower().Trim();

            return await _context.TempEmployeeRoles
                .Where(x => x.Status == true &&
                    (x.EmpNo.ToLower().Contains(searchTerm) ||
                     x.Id.ToString().Contains(searchTerm)))
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task<TempEmployeeRole?> GetByIdForUpdateAsync(int id)
        {
            return await _context.TempEmployeeRoles.FindAsync(id);
        }
    }
}
