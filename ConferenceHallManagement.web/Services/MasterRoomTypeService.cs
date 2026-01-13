using System.Net.Http.Json;
using Models_ConferenceHallManagement.AppDbModels;
using Microsoft.Extensions.Logging;

namespace ConferenceHallManagement.Web.Services
{
    public class MasterRoomTypeService
    {
        private readonly HttpClient _http;
        private readonly ILogger<MasterRoomTypeService> _logger;

        public MasterRoomTypeService(
            HttpClient http,
            ILogger<MasterRoomTypeService> logger)
        {
            _http = http;
            _logger = logger;
        }

        public async Task<List<MasterRoomType>> GetAllAsync()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<List<MasterRoomType>>(
                    "api/room-type");

                return result ?? new List<MasterRoomType>();
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to fetch room types from API: {ex.Message}. Using mock data.");
                return GetMockData();
            }
        }

        public async Task<MasterRoomType?> GetByIdAsync(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<MasterRoomType>(
                    $"api/room-type/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to fetch room type by ID: {ex.Message}");
                return GetMockData().FirstOrDefault(x => x.Id == id);
            }
        }

        public async Task CreateAsync(MasterRoomType model)
        {
            try
            {
                await _http.PostAsJsonAsync("api/room-type", model);
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to create room type: {ex.Message}");
            }
        }

        public async Task UpdateAsync(int id, MasterRoomType model)
        {
            try
            {
                await _http.PutAsJsonAsync($"api/room-type/{id}", model);
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to update room type: {ex.Message}");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await _http.DeleteAsync($"api/room-type/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to delete room type: {ex.Message}");
            }
        }

        // 🔹 Mock data (same idea as Booking Status)
        private List<MasterRoomType> GetMockData()
        {
            return new List<MasterRoomType>
            {
                new MasterRoomType
                {
                    Id = 1,
                    RoomTypeId = 1,
                    RoomTypeEn = "Conference Room",
                    RoomTypeHi = "सम्मेलन कक्ष",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "System",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "System"
                },
                new MasterRoomType
                {
                    Id = 2,
                    RoomTypeId = 2,
                    RoomTypeEn = "Board Room",
                    RoomTypeHi = "बोर्ड रूम",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "System",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "System"
                },
                new MasterRoomType
                {
                    Id = 3,
                    RoomTypeId = 3,
                    RoomTypeEn = "Training Room",
                    RoomTypeHi = "प्रशिक्षण कक्ष",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "System",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "System"
                }
            };
        }
    }
}
