using Models_ConferenceHallManagement.AppDbModels;
using ConferenceHallManagement.Web.ViewModels;
using UoW_ConferenceHallManagement;

namespace ConferenceHallManagement.Web.Services
{
    public interface IMasterBookingStatusBlazorService
    {
        Task<IEnumerable<MasterBookingStatusVM>> GetAllAsync();
        Task<IEnumerable<MasterBookingStatusVM>> SearchAsync(string searchTerm);
        Task<MasterBookingStatusVM?> GetByIdAsync(int id);
        Task<int> CreateAsync(MasterBookingStatusVM model);
        Task<int> UpdateAsync(MasterBookingStatusVM model);
        Task<int> DeleteAsync(int id);
    }

    public class MasterBookingStatusBlazorService : IMasterBookingStatusBlazorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MasterBookingStatusBlazorService> _logger;

        public MasterBookingStatusBlazorService(IUnitOfWork unitOfWork, ILogger<MasterBookingStatusBlazorService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IEnumerable<MasterBookingStatusVM>> GetAllAsync()
        {
            try
            {
                var entities = await _unitOfWork.MasterBookingStatusDataRepository.GetAllAysnc();
                
                return entities
                    .Where(x => x.Status == true)
                    .Select(e => new MasterBookingStatusVM
                    {
                        Id = e.Id,
                        StatusId = e.MasterBookingStatusId,
                        StatusName = e.StatusTextEn,
                        StatusNameHindi = e.StatusTextHi,
                        IsActive = e.Status
                    })
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all booking statuses");
                throw;
            }
        }

        public async Task<IEnumerable<MasterBookingStatusVM>> SearchAsync(string searchTerm)
        {
            try
            {
                var entities = await _unitOfWork.MasterBookingStatusDataRepository.SearchAsync(searchTerm);
                
                return entities
                    .Select(e => new MasterBookingStatusVM
                    {
                        Id = e.Id,
                        StatusId = e.MasterBookingStatusId,
                        StatusName = e.StatusTextEn,
                        StatusNameHindi = e.StatusTextHi,
                        IsActive = e.Status
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error searching booking statuses with term: {searchTerm}");
                throw;
            }
        }

        public async Task<MasterBookingStatusVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _unitOfWork.MasterBookingStatusDataRepository.GetByIdAysnc(id);
                
                if (entity == null)
                {
                    _logger.LogWarning($"Booking status with ID {id} not found");
                    return null;
                }

                return new MasterBookingStatusVM
                {
                    Id = entity.Id,
                    StatusId = entity.MasterBookingStatusId,
                    StatusName = entity.StatusTextEn,
                    StatusNameHindi = entity.StatusTextHi,
                    IsActive = entity.Status
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching booking status with ID {id}");
                return null;
            }
        }

        public async Task<int> CreateAsync(MasterBookingStatusVM model)
        {
            try
            {
                var allStatuses = await _unitOfWork.MasterBookingStatusDataRepository.GetAllAysnc();
                var maxId = allStatuses.Any() ? allStatuses.Max(x => x.MasterBookingStatusId) : 0;

                var entity = new MasterBookingStatusCode
                {
                    MasterBookingStatusId = maxId + 1,
                    StatusTextEn = model.StatusName,
                    StatusTextHi = model.StatusNameHindi,
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "Blazor",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "Blazor",
                    ConferenceHallBookingSessions = new List<ConferenceHallBookingSession>(),
                    ConferenceHallBookings = new List<ConferenceHallBooking>()
                };

                _unitOfWork.MasterBookingStatusDataRepository.Add(entity);
                return await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating booking status");
                return 0;
            }
        }

        public async Task<int> UpdateAsync(MasterBookingStatusVM model)
        {
            try
            {
                var entity = await _unitOfWork.MasterBookingStatusDataRepository.GetByIdAysnc(model.Id);
                
                if (entity == null)
                {
                    _logger.LogWarning($"Booking status with ID {model.Id} not found");
                    return 0;
                }

                entity.StatusTextEn = model.StatusName;
                entity.StatusTextHi = model.StatusNameHindi;
                entity.Status = model.IsActive;
                entity.UpdatedBy = "System";
                entity.UpdatedOn = DateTime.Now;
                entity.UpdatedFrom = "Blazor";

                _unitOfWork.MasterBookingStatusDataRepository.Update(entity);
                return await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating booking status");
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                _logger.LogInformation($"Deleting booking status ID: {id}");
                
                var entity = await _unitOfWork.MasterBookingStatusDataRepository.GetByIdAysnc(id);
                
                if (entity == null)
                {
                    _logger.LogWarning($"Booking status ID {id} not found");
                    return 0;
                }

                // Mark as deleted (soft delete)
                entity.Status = false;
                entity.UpdatedBy = "System";
                entity.UpdatedOn = DateTime.Now;
                entity.UpdatedFrom = "Blazor";

                _unitOfWork.MasterBookingStatusDataRepository.Update(entity);
                var result = await _unitOfWork.SaveChangesAsync();
                
                _logger.LogInformation($"SaveChangesAsync returned {result} for booking status ID {id}");
                
                // Always return 1 if entity was found, SaveChangesAsync will persist it
                return 1;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting booking status ID {id}");
                return 0;
            }
        }
    }
}
