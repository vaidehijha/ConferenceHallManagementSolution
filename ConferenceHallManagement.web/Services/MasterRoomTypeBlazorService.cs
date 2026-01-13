using Models_ConferenceHallManagement.AppDbModels;
using ConferenceHallManagement.Web.ViewModels;
using UoW_ConferenceHallManagement;
using Microsoft.EntityFrameworkCore;

namespace ConferenceHallManagement.Web.Services
{
    public interface IMasterRoomTypeBlazorService
    {
        Task<IEnumerable<MasterRoomTypeVM>> GetAllAsync();
        Task<IEnumerable<MasterRoomTypeVM>> SearchAsync(string searchTerm);
        Task<MasterRoomTypeVM?> GetByIdAsync(int id);
        Task<int> CreateAsync(MasterRoomTypeVM model);
        Task<int> UpdateAsync(MasterRoomTypeVM model);
        Task<int> DeleteAsync(int id);
    }

    public class MasterRoomTypeBlazorService : IMasterRoomTypeBlazorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MasterRoomTypeBlazorService> _logger;

        public MasterRoomTypeBlazorService(
            IUnitOfWork unitOfWork,
            ILogger<MasterRoomTypeBlazorService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IEnumerable<MasterRoomTypeVM>> GetAllAsync()
        {
            try
            {
                var entities = await _unitOfWork.MasterRoomTypeDataRepository.GetAllAysnc();
                return entities.Where(x => x.Status)
                    .Select(e => new MasterRoomTypeVM
                    {
                        Id = e.Id,
                        RoomTypeId = e.RoomTypeId,
                        RoomTypeEn = e.RoomTypeEn ?? "",
                        RoomTypeHi = e.RoomTypeHi ?? "",
                        IsActive = e.Status
                    }).OrderByDescending(x => x.Id).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllAsync error");
                return Enumerable.Empty<MasterRoomTypeVM>();
            }
        }

        public async Task<IEnumerable<MasterRoomTypeVM>> SearchAsync(string searchTerm)
        {
            try
            {
                var entities = await _unitOfWork.MasterRoomTypeDataRepository.SearchAsync(searchTerm);
                return entities.Select(e => new MasterRoomTypeVM
                {
                    Id = e.Id,
                    RoomTypeId = e.RoomTypeId,
                    RoomTypeEn = e.RoomTypeEn ?? "",
                    RoomTypeHi = e.RoomTypeHi ?? "",
                    IsActive = e.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchAsync error");
                return Enumerable.Empty<MasterRoomTypeVM>();
            }
        }

        public async Task<MasterRoomTypeVM?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _unitOfWork.MasterRoomTypeDataRepository.GetByIdAysnc(id);
                if (entity == null) return null;

                return new MasterRoomTypeVM
                {
                    Id = entity.Id,
                    RoomTypeId = entity.RoomTypeId,
                    RoomTypeEn = entity.RoomTypeEn ?? "",
                    RoomTypeHi = entity.RoomTypeHi ?? "",
                    IsActive = entity.Status
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetByIdAsync error: {id}");
                return null;
            }
        }

        public async Task<int> CreateAsync(MasterRoomTypeVM model)
        {
            try
            {
                var all = await _unitOfWork.MasterRoomTypeDataRepository.GetAllAysnc();
                var maxId = all.Any() ? all.Max(x => x.RoomTypeId) : 0;

                var entity = new MasterRoomType
                {
                    RoomTypeId = maxId + 1,
                    RoomTypeEn = model.RoomTypeEn,
                    RoomTypeHi = model.RoomTypeHi ?? "",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "Blazor",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "Blazor"
                };

                _unitOfWork.MasterRoomTypeDataRepository.Add(entity);
                return await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CreateAsync error");
                return 0;
            }
        }

        public async Task<int> UpdateAsync(MasterRoomTypeVM model)
        {
            try
            {
                var existingData = await _unitOfWork.MasterRoomTypeDataRepository.GetByIdAysnc(model.RoomTypeId);

                if (existingData == null)
                {
                    _logger.LogWarning($"Delete: ID {model.RoomTypeId} not found");
                    return 0;
                }
                existingData.RoomTypeEn = model.RoomTypeEn;
                existingData.RoomTypeHi = model.RoomTypeHi ?? "";
                existingData.Status = model.IsActive;
                existingData.UpdatedBy = "System";
                existingData.UpdatedOn = DateTime.Now;
                existingData.UpdatedFrom = "Blazor";

                _unitOfWork.MasterRoomTypeDataRepository.Update(existingData);
                var result = await _unitOfWork.SaveChangesAsync();



                //var repo = _unitOfWork.MasterRoomTypeDataRepository;
                //var context = repo.GetContext();

                //var entity = await context.MasterRoomTypes
                //    .FirstOrDefaultAsync(x => x.Id == model.Id);

                //if (entity == null)
                //{
                //    _logger.LogWarning($"Update: ID {model.Id} not found");
                //    return 0;
                //}

                //context.Entry(entity).State = EntityState.Modified;
                //entity.RoomTypeEn = model.RoomTypeEn;
                //entity.RoomTypeHi = model.RoomTypeHi ?? "";
                //entity.Status = model.IsActive;
                //entity.UpdatedBy = "System";
                //entity.UpdatedOn = DateTime.Now;
                //entity.UpdatedFrom = "Blazor";

                //var result = await context.SaveChangesAsync();
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
                //var repo = _unitOfWork.MasterRoomTypeDataRepository;
                //var context = repo.GetContext();

                var existingData = await _unitOfWork.MasterRoomTypeDataRepository.GetByIdAysnc(id);
                
                if (existingData == null)
                {
                    _logger.LogWarning($"Delete: ID {id} not found");
                    return 0;
                }

                existingData.Status = false;
                existingData.UpdatedBy = "System";
                existingData.UpdatedOn = DateTime.Now;
                existingData.UpdatedFrom = "Blazor";

                _unitOfWork.MasterRoomTypeDataRepository.Update(existingData);
                var result = await _unitOfWork.SaveChangesAsync();

                //context.Entry(entity).State = EntityState.Modified;
                //var result = await context.SaveChangesAsync();
                //_logger.LogInformation($"Delete success: {result}");
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
