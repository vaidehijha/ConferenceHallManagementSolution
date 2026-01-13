using System.Net.Http.Json;
using Models_ConferenceHallManagement.AppDbModels;

namespace ConferenceHallManagement.Web.Services
{
    public class MasterBookingStatusService
    {
        private readonly HttpClient _http;
        private readonly ILogger<MasterBookingStatusService> _logger;

        public MasterBookingStatusService(HttpClient http, ILogger<MasterBookingStatusService> logger)
        {
            _http = http;
            _logger = logger;
        }

        public async Task<List<MasterBookingStatusCode>> GetAllAsync()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<List<MasterBookingStatusCode>>(
                    "api/booking-status");
                return result ?? new List<MasterBookingStatusCode>();
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to fetch from API: {ex.Message}. Using mock data.");
                return GetMockData();
            }
        }

        public async Task CreateAsync(MasterBookingStatusCode model)
        {
            try
            {
                await _http.PostAsJsonAsync("api/booking-status", model);
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to create: {ex.Message}");
                // In production, you might want to throw or handle differently
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await _http.DeleteAsync($"api/booking-status/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to delete: {ex.Message}");
            }
        }

        public async Task<MasterBookingStatusCode?> GetByIdAsync(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<MasterBookingStatusCode>(
                    $"api/booking-status/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to fetch by ID: {ex.Message}");
                return GetMockData().FirstOrDefault(x => x.Id == id);
            }
        }

        public async Task UpdateAsync(int id, MasterBookingStatusCode model)
        {
            try
            {
                await _http.PutAsJsonAsync($"api/booking-status/{id}", model);
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Failed to update: {ex.Message}");
            }
        }

        // Mock data for development/testing
        private List<MasterBookingStatusCode> GetMockData()
        {
            return new List<MasterBookingStatusCode>
            {
                new MasterBookingStatusCode
                {
                    Id = 1,
                    MasterBookingStatusId = 1,
                    StatusTextEn = "Pending",
                    StatusTextHi = "लंबित",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "System",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "System"
                },
                new MasterBookingStatusCode
                {
                    Id = 2,
                    MasterBookingStatusId = 2,
                    StatusTextEn = "Approved",
                    StatusTextHi = "अनुमोदित",
                    Status = true,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    CreatedFrom = "System",
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    UpdatedFrom = "System"
                },
                new MasterBookingStatusCode
                {
                    Id = 3,
                    MasterBookingStatusId = 3,
                    StatusTextEn = "Rejected",
                    StatusTextHi = "अस्वीकृत",
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
