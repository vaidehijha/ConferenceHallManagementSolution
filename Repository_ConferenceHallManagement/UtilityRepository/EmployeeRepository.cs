using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using Models_ConferenceHallManagement.EmpDetDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConferenceHallManagement.UtilityRepository
{
    public interface IEmployeeRepository
    {
        Task<VActiveUserDetailsWith8DigitEmpNo?> GetEmployeeById(string empNum);
        Task<bool> AuthenticateUser(string userName, string password);
        Task<IEnumerable<TempEmployeeRole>?> GetEmployeeRoles(string empNo);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpdetContext _db;
        private readonly ConferenceHallManagementContext _dbApp;

        public EmployeeRepository(EmpdetContext db, ConferenceHallManagementContext dbApp)
        {
            _db = db;
            _dbApp = dbApp;
        }

        public async Task<VActiveUserDetailsWith8DigitEmpNo?> GetEmployeeById(string userName)
        {
            // SIR KA DEMO MOCK DATA
            VActiveUserDetailsWith8DigitEmpNo emp = new VActiveUserDetailsWith8DigitEmpNo()
            {
                EightDigitEmpNo = "60020656",
                Empimgguid = new Guid("12345678-1234-1234-1234-123456789012"),
                Empname = "Demo Employee",
                Pgemail = "demo@powergrid.in",
                Cellno = "9876543210"
            };

            // Demo validation
            if (userName.ToLower() == "60020656" || userName.ToLower() == "demo@powergrid.in")
            {
                return emp;
            }

            return null;
        }

        public async Task<bool> AuthenticateUser(string userName, string password)
        {
            // Demo: hardcoded password
            await Task.Delay(100); // Async simulate
            return password == "test123";
        }

        public async Task<IEnumerable<TempEmployeeRole>?> GetEmployeeRoles(string empNo)
        {
            // Demo roles
            return new List<TempEmployeeRole>
            {
                new TempEmployeeRole { EmpNo = empNo, RoleId = 1234 },
                new TempEmployeeRole { EmpNo = empNo, RoleId = 4321}
            };
        }
    }
}
