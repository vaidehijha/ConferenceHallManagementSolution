using Models_ConferenceHallManagement.AppDbModels;
using ProjectUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBllCHMRoomType
    {
        Task<int> AddMasterRoomType(MasterRoomType roomType);
        Task<int> UpdateMasterRoomType(MasterRoomType roomType);
        Task<MasterRoomType> GetMasterRoomTypeByRoomTypeId(int roomTypeId);
        Task<IEnumerable<MasterRoomType>?> GetAllMasterRoomTypes();
    }
    public class BLLCHMRoomType: IBllCHMRoomType
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICacheStorage _ICacheStorage;

        public BLLCHMRoomType(IUnitOfWork unitOfWork, ICacheStorage ICacheStorage)
        {
            _unitOfWork = unitOfWork;
            _ICacheStorage = ICacheStorage;
        }
        public async Task<int> AddMasterRoomType(MasterRoomType roomType)
        {
            if (roomType == null)
            {
                throw new ArgumentNullException(nameof(roomType), "Room Type cannot be null");
            }
            _unitOfWork.MasterRoomTypeDataRepository.Add(roomType);
            await _unitOfWork.SaveChangesAsync();
            return roomType.Id; 
        }
        public async Task<int> UpdateMasterRoomType(MasterRoomType roomType)
        {
            if (roomType == null)
            {
                throw new ArgumentNullException(nameof(roomType), "Room Type cannot be null");
            }
            _unitOfWork.MasterRoomTypeDataRepository.Update(roomType);
            await _unitOfWork.SaveChangesAsync();
            return roomType.Id;
        }
        public async Task<MasterRoomType> GetMasterRoomTypeByRoomTypeId(int roomTypeId)
        {
            //var roomType = await _unitOfWork.MasterRoomTypeDataRepository.GetMasterBookingroomTypeByroomTypeId(roomTypeId);
            var roomType = await _unitOfWork.MasterRoomTypeDataRepository.GetByIdAysnc(roomTypeId);
            if (roomType == null)
            {
                throw new KeyNotFoundException($"Room Type with ID {roomTypeId} not found.");
            }
            return roomType;
        }

        public async Task<IEnumerable<MasterRoomType>?> GetAllMasterRoomTypes()
        {
            string storageKey = Consts.CacheMasterCHMRoomType;
            List<MasterRoomType> lr = _ICacheStorage.Retrieve<List<MasterRoomType>>(storageKey);
            if (lr == null)
            {
                var dataList = await _unitOfWork.MasterRoomTypeDataRepository.GetAllAysnc();
                lr = dataList?.Where(x => x.Status == true).ToList();
                if (lr != null)
                {
                    _ICacheStorage.Store(storageKey, lr);
                }
                return lr;
            }
            return lr;
        }

    }
}
