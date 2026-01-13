using Models_ConferenceHallManagement.AppDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBLLConferenceHallBooingSessions
    {
        Task<int> AddConferenceHallBookingSession(ConferenceHallBookingSession bookingSession);
        Task<int> UpdateConferenceHallBookingSession(ConferenceHallBookingSession bookingSession);
        Task<ConferenceHallBookingSession> GetConferenceHallBookingSessionBybookingSessionId(int bookingSessionId);
        Task<IEnumerable<ConferenceHallBookingSession>?> GetAllConferenceHallBookingSessions();
    }
    public class BLLConferenceHallBooingSessions: IBLLConferenceHallBooingSessions
    {
        private readonly IUnitOfWork _unitOfWork;

        public BLLConferenceHallBooingSessions(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> AddConferenceHallBookingSession(ConferenceHallBookingSession bookingSession)
        {
            if (bookingSession == null)
            {
                throw new ArgumentNullException(nameof(bookingSession), "Booking Session cannot be null");
            }
            _unitOfWork.CHBookingSessionsDataRepository.Add(bookingSession);
            await _unitOfWork.SaveChangesAsync();
            return bookingSession.Id;
        }
        public async Task<int> UpdateConferenceHallBookingSession(ConferenceHallBookingSession bookingSession)
        {
            if (bookingSession == null)
            {
                throw new ArgumentNullException(nameof(bookingSession), "Booking Session cannot be null");
            }
            _unitOfWork.CHBookingSessionsDataRepository.Update(bookingSession);
            await _unitOfWork.SaveChangesAsync();
            return bookingSession.Id;
        }
        public async Task<ConferenceHallBookingSession> GetConferenceHallBookingSessionBybookingSessionId(int bookingSessionId)
        {
            //var bookingSession = await _unitOfWork.ConferenceHallBookingSessionDataRepository.GetMasterBookingbookingSessionBybookingSessionId(bookingSessionId);
            var bookingSession = await _unitOfWork.CHBookingSessionsDataRepository.GetByIdAysnc(bookingSessionId);
            if (bookingSession == null)
            {
                throw new KeyNotFoundException($"Booking Session with ID {bookingSessionId} not found.");
            }
            return bookingSession;
        }

        public async Task<IEnumerable<ConferenceHallBookingSession>?> GetAllConferenceHallBookingSessions()
        {
            var dataList = await _unitOfWork.CHBookingSessionsDataRepository.GetAllAysnc();
            return dataList?.Where(x => x.Status != 0);
        }
    }
}
