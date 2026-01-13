using Models_ConferenceHallManagement.AppDbModels;
using ConferenceHallManagement.Web.ViewModels;
using UoW_ConferenceHallManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConferenceHallManagement.web.Services
{
    public interface ITempEmployeeRoleBlazorService
    {
        Task<IEnumerable<TempEmployeeRoleVM>> GetAllAsync();
        Task<IEnumerable<TempEmployeeRoleVM>> SearchAsync(string searchTerm);
        Task<TempEmployeeRoleVM?> GetByIdAsync(int id);
        Task<int> CreateAsync(TempEmployeeRoleVM model);
        Task<int> UpdateAsync(TempEmployeeRoleVM model);
        Task<int> DeleteAsync(int id);
    }

    public class TempEmployeeRoleBlazorService : ITempEmployeeRoleBlazorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TempEmployeeRoleBlazorService> _logger;

        public TempEmployeeRoleBlazorService(
            IUnitOfWork unitOfWork,
            ILogger<TempEmployeeRoleBlazorService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IEnumerable<TempEmployeeRoleVM>> GetAllAsync()
        {
            try
            {
                var entities = await _unitOfWork.MasterTempEmployeeRoleDataRepository.GetAllAysnc();
                return entities.Where(x => x.Status)
                    .Select(e => new TempEmployeeRoleVM
                    {
                        Id = e.Id,
                        EmployeeNo = e.EmpNo ?? "",
                        ApplicationId = e.ApplicationId,
                        RegionId = e.RegionId,
                        LocationId = e.LocationId,
                        DepartmentId = e.DepartmentId,
                        RoleId = e.RoleId,
                        IsAllowWrite = e.IsAllowWrite,
                        IsActive = e.Status
                    }).OrderByDescending(x => x.Id).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllAsync error");
                return Enumerable.Empty<TempEmployeeRoleVM>();
            }
        }

        public async Task<IEnumerable<TempEmployeeRoleVM>> SearchAsync(string searchTerm)
        {
            try
            {
                var entities = await _unitOfWork.MasterTempEmployeeRoleDataRepository.SearchAsync(searchTerm);
                return entities.Select(e => new TempEmployeeRoleVM
                {
                    Id = e.Id,
                    EmployeeNo = e.EmpNo ?? "",
                    ApplicationId = e.ApplicationId,
                    RegionId = e.RegionId,
                    LocationId = e.LocationId,
                    DepartmentId = e.DepartmentId,
                    RoleId = e.RoleId,
                    IsAllowWrite = e.IsAllowWrite,
                    IsActive = e.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchAsync error");
                return Enumerable.Empty<TempEmployeeRoleVM>();
            }
        }

        public async Task<TempEmployeeRoleVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _unitOfWork.MasterTempEmployeeRoleDataRepository.GetByIdAysnc(id);
                if (entity == null) return null;

                return new TempEmployeeRoleVM
                {
                    Id = entity.Id,
                    EmployeeNo = entity.EmpNo ?? "",
                    ApplicationId = entity.ApplicationId,
                    RegionId = entity.RegionId,
                    LocationId = entity.LocationId,
                    DepartmentId = entity.DepartmentId,
                    RoleId = entity.RoleId,
                    IsAllowWrite = entity.IsAllowWrite,
                    IsActive = entity.Status
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetByIdAsync error: {id}");
                return null;
            }
        }

        public async Task<int> CreateAsync(TempEmployeeRoleVM model)
        {
            try
            {
                var entity = new TempEmployeeRole
                {
                    EmpNo = model.EmployeeNo,
                    ApplicationId = model.ApplicationId,
                    RegionId = model.RegionId,
                    LocationId = model.LocationId,
                    DepartmentId = model.DepartmentId,
                    RoleId = model.RoleId,
                    IsAllowWrite = model.IsAllowWrite,
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "Blazor",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "Blazor"
                };

                _unitOfWork.MasterTempEmployeeRoleDataRepository.Add(entity);
                return await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CreateAsync error");
                return 0;
            }
        }

        public async Task<int> UpdateAsync(TempEmployeeRoleVM model)
        {
            try
            {
                var existingData = await _unitOfWork.MasterTempEmployeeRoleDataRepository.GetByIdAysnc(model.Id);

                if (existingData == null)
                {
                    _logger.LogWarning($"Update: ID {model.Id} not found");
                    return 0;
                }

                existingData.EmpNo = model.EmployeeNo;
                existingData.ApplicationId = model.ApplicationId;
                existingData.RegionId = model.RegionId;
                existingData.LocationId = model.LocationId;
                existingData.DepartmentId = model.DepartmentId;
                existingData.RoleId = model.RoleId;
                existingData.IsAllowWrite = model.IsAllowWrite;
                existingData.Status = model.IsActive;
                existingData.UpdatedBy = "System";
                existingData.UpdatedOn = DateTime.Now;
                existingData.UpdatedFrom = "Blazor";

                _unitOfWork.MasterTempEmployeeRoleDataRepository.Update(existingData);
                var result = await _unitOfWork.SaveChangesAsync();

                _logger.LogInformation($"Update success: {result} rows");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"UpdateAsync error ID: {model.Id}");
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                var existingData = await _unitOfWork.MasterTempEmployeeRoleDataRepository.GetByIdAysnc(id);

                if (existingData == null)
                {
                    _logger.LogWarning($"Delete: ID {id} not found");
                    return 0;
                }

                existingData.Status = false;
                existingData.UpdatedBy = "System";
                existingData.UpdatedOn = DateTime.Now;
                existingData.UpdatedFrom = "Blazor";

                _unitOfWork.MasterTempEmployeeRoleDataRepository.Update(existingData);
                var result = await _unitOfWork.SaveChangesAsync();

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"DeleteAsync error ID: {id}");
                return 0;
            }
        }
    }
}
