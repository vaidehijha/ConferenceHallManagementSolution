using Models_ConferenceHallManagement.AppDbModels;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBllCHMBookingStatus
    {
        Task<int> AddMasterBookingStatus(MasterBookingStatusCode status);
        Task<int> UpdateMasterBookingStatus(MasterBookingStatusCode status);
        //Task<MasterBookingStatusCode> GetMasterBookingStatusById(int id);
        Task<MasterBookingStatusCode> GetMasterBookingStatusByStatusId(int statusId);
        Task<IEnumerable<MasterBookingStatusCode>?> GetAllMasterBookingStatuses();
    }
    public class BLLCHMBookingStatus : IBllCHMBookingStatus
    {
        private readonly IUnitOfWork _unitOfWork;

        public BLLCHMBookingStatus(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> AddMasterBookingStatus(MasterBookingStatusCode status)
        {
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status), "Master booking status cannot be null");
            }
            _unitOfWork.MasterBookingStatusDataRepository.Add(status);
            await _unitOfWork.SaveChangesAsync();
            return status.Id; 
        }
        public async Task<int> UpdateMasterBookingStatus(MasterBookingStatusCode status)
        {
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status), "Master booking status cannot be null");
            }
            _unitOfWork.MasterBookingStatusDataRepository.Update(status);
            await _unitOfWork.SaveChangesAsync();
            return status.Id;

        }
        public async Task<MasterBookingStatusCode> GetMasterBookingStatusByStatusId(int statusId)
        {
            //var status = await _unitOfWork.MasterBookingStatusDataRepository.GetMasterBookingStatusByStatusId(statusId);
            var status = await _unitOfWork.MasterBookingStatusDataRepository.GetByIdAysnc(statusId);
            if (status == null)
            {
                throw new KeyNotFoundException($"Master booking status with ID {statusId} not found.");
            }
            return status;
        }
        public async Task<IEnumerable<MasterBookingStatusCode>?> GetAllMasterBookingStatuses()
        {
            var dataList = await _unitOfWork.MasterBookingStatusDataRepository.GetAllAysnc();
            return dataList?.Where(x => x.Status == true);
        }

        //public async Task<MasterBookingStatusCode> GetMasterBookingStatusById(int id)
        //{
        //    var status = await _unitOfWork.MasterBookingStatusDataRepository.GetByIdAysnc(id);
        //    if (status == null)
        //    {
        //        throw new KeyNotFoundException($"Master booking status with ID {id} not found.");
        //    }
        //    return status; // Return the master booking status by ID
        //}
        

        
    }
}
