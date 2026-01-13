using Models_ConferenceHallManagement.AppDbModels;
using Models_ConferenceHallManagement.EmpDetDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBllEmployee
    {
        Task<VActiveUserDetailsWith8DigitEmpNo?> GetEmployeeByUserName(string userName);
        Task<bool> AuthenticateUser(string userName, string password);
        Task<IEnumerable<TempEmployeeRole>?> GetEmployeeRoles(string empNo);
    }
    public class BLLEmployee : IBllEmployee
    {
        private readonly IUnitOfWork _unitOfWork;
        public BLLEmployee(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;            
        }
        public async Task<VActiveUserDetailsWith8DigitEmpNo?> GetEmployeeByUserName(string userName)
        {
            var empData = await _unitOfWork.EmployeeRepository.GetEmployeeById(userName);
            if (empData == null)
            {
                throw new KeyNotFoundException($"Master booking status with ID {userName} not found.");
            }
            return empData; 
        }
        public async Task<bool> AuthenticateUser(string userName, string password)
        {
            return await _unitOfWork.EmployeeRepository.AuthenticateUser(userName, password);
        }
        public async Task<IEnumerable<TempEmployeeRole>?> GetEmployeeRoles(string empNo)
        {
            return await _unitOfWork.EmployeeRepository.GetEmployeeRoles(empNo);
        }
    }
}
