using ConferenceHallManagement.web.ViewModels;
using Models_ConferenceHallManagement.AppDbModels;
using Repository_ConferenceHallManagement.AppDataRepositoy;

namespace ConferenceHallManagement.web.Services
{
    public class HallConfigurationService
    {
        private readonly IConferenceHallDataRepository _repo;

        public HallConfigurationService(IConferenceHallDataRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> SaveHallConfiguration(HallConfigurationVM vm)
        {
            try
            {
                // Get current timestamp and user info
                var currentTime = DateTime.Now;
                var currentUser = "System"; // TODO: Replace with actual logged-in user
                var currentLocation = "Web"; // TODO: Replace with actual location/IP if needed

                // 1. Map ViewModel (UI Data) -> Database Entity
                var hallEntity = new ConferenceHall
                {
                    HallName = vm.HallName,
                    Capacity = vm.Capacity,
                    Location = vm.Location,
                    
                    // Populate required fields
                    HallNameEn = vm.HallName,
                    HallNameHi = vm.HallName, // TODO: Add Hindi translation if available
                    Floor = "Ground", // TODO: Add Floor field to ViewModel
                    RegionId = 1, // TODO: Add RegionId to ViewModel or get from context
                    LocationId = 1, // TODO: Add LocationId to ViewModel or get from context
                    Status = true,
                    IsApprovalRequired = false,
                    CreatedBy = currentUser,
                    CreatedOn = currentTime,
                    CreatedFrom = currentLocation,
                    UpdatedBy = currentUser,
                    UpdatedOn = currentTime,
                    UpdatedFrom = currentLocation,

                    // 2. Map the Sessions List
                    // Convert DateTime to TimeSpan for the database entity
                    ConferenceHallSessions = vm.Sessions.Select(s => new ConferenceHallSession
                    {
                        SessionName = s.SessionName,
                        StartTime = s.StartTime.TimeOfDay,
                        EndTime = s.EndTime.TimeOfDay,
                        Price = s.Price,
                        
                        // Populate required fields for session
                        SessionEn = s.SessionName,
                        SessionHi = s.SessionName, // TODO: Add Hindi translation if available
                        Status = true,
                        CreatedBy = currentUser,
                        CreatedOn = currentTime,
                        CreatedFrom = currentLocation,
                        UpdatedBy = currentUser,
                        UpdatedOn = currentTime,
                        UpdatedFrom = currentLocation
                    }).ToList()
                };

                // 3. Send to Repository
                return await _repo.CreateHallWithSessionsAsync(hallEntity);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}