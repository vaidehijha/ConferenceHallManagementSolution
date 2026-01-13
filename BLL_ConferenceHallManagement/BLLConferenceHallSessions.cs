using Models_ConferenceHallManagement.AppDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBLLConferenceHallSessions
    {
        Task<int> AddConferenceHallSession(ConferenceHallSession session);
        Task<int> UpdateConferenceHallSession(ConferenceHallSession session);
        Task<ConferenceHallSession> GetConferenceHallSessionBysessionId(int sessionId);
        Task<IEnumerable<ConferenceHallSession>?> GetAllConferenceHallSessions();
        Task<IEnumerable<ConferenceHallSession>?> GetAllConferenceHallSessionsByHallId(int hallId);
    }
    public class BLLConferenceHallSessions: IBLLConferenceHallSessions
    {
        private readonly IUnitOfWork _unitOfWork;

        public BLLConferenceHallSessions(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> AddConferenceHallSession(ConferenceHallSession session)
        {
            if (session == null)
            {
                throw new ArgumentNullException(nameof(session), "Room Type cannot be null");
            }
            _unitOfWork.CHSessionDataRepository.Add(session);
            await _unitOfWork.SaveChangesAsync();
            return session.SessionId; 
        }
        public async Task<int> UpdateConferenceHallSession(ConferenceHallSession session)
        {
            if (session == null)
            {
                throw new ArgumentNullException(nameof(session), "Room Session cannot be null");
            }
            _unitOfWork.CHSessionDataRepository.Update(session);
            await _unitOfWork.SaveChangesAsync();
            return session.SessionId;
        }
        public async Task<ConferenceHallSession> GetConferenceHallSessionBysessionId(int sessionId)
        {
            //var session = await _unitOfWork.CHSessionDataRepository.GetMasterBookingsessionBysessionId(sessionId);
            var session = await _unitOfWork.CHSessionDataRepository.GetByIdAysnc(sessionId);
            if (session == null)
            {
                throw new KeyNotFoundException($"Room Session with ID {sessionId} not found.");
            }
            return session;
        }

        public async Task<IEnumerable<ConferenceHallSession>?> GetAllConferenceHallSessions()
        {
            var dataList = await _unitOfWork.CHSessionDataRepository.GetAllAysnc();
            return dataList?.Where(x => x.Status == true);
        }
        public async Task<IEnumerable<ConferenceHallSession>?> GetAllConferenceHallSessionsByHallId(int hallId)
        {
            var dataList = await _unitOfWork.CHSessionDataRepository.GetAllAysnc();
            return dataList?.Where(x => x.Status == true && x.HallId == hallId);
        }
    }
}
