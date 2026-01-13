using Models_ConferenceHallManagement.AppDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;

namespace BLL_ConferenceHallManagement
{
    public interface IBLLConferenceHallBookings
    {
        Task<int> AddConferenceHallBooking(ConferenceHallBooking booking);
        Task<int> UpdateConferenceHallBooking(ConferenceHallBooking booking);
        Task<ConferenceHallBooking> GetConferenceHallBookingBybookingId(int bookingId);
        Task<IEnumerable<ConferenceHallBooking>?> GetAllConferenceHallBookings();
    }
    public class BLLConferenceHallBookings: IBLLConferenceHallBookings
    {
        private readonly IUnitOfWork _unitOfWork;

        public BLLConferenceHallBookings(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> AddConferenceHallBooking(ConferenceHallBooking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Booking cannot be null");
            }
            _unitOfWork.ConferenceHallBookingDataRepository.Add(booking);
            await _unitOfWork.SaveChangesAsync();
            return booking.BookingId;
        }
        public async Task<int> UpdateConferenceHallBooking(ConferenceHallBooking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Booking cannot be null");
            }
            _unitOfWork.ConferenceHallBookingDataRepository.Update(booking);
            await _unitOfWork.SaveChangesAsync();
            return booking.BookingId;
        }
        public async Task<ConferenceHallBooking> GetConferenceHallBookingBybookingId(int bookingId)
        {
            //var booking = await _unitOfWork.ConferenceHallBookingDataRepository.GetMasterBookingbookingBybookingId(bookingId);
            var booking = await _unitOfWork.ConferenceHallBookingDataRepository.GetByIdAysnc(bookingId);
            if (booking == null)
            {
                throw new KeyNotFoundException($"Booking with ID {bookingId} not found.");
            }
            //booking.ConferenceHallBookingSessions = booking.ConferenceHallBookingSessions
            //            .Where(s => s.Status != 3 && s.Status != 4)
            //            .ToList();
            return booking;
        }

        public async Task<IEnumerable<ConferenceHallBooking>?> GetAllConferenceHallBookings()
        {
            var dataList = await _unitOfWork.ConferenceHallBookingDataRepository.GetAllAysnc();
            //dataList = dataList?.Where(x => x.Status != 3 && x.Status != 4);
            //if (dataList != null)
            //{
            //    foreach (var booking in dataList)
            //    {
            //        booking.ConferenceHallBookingSessions = booking.ConferenceHallBookingSessions
            //            .Where(s => s.Status != 3 && s.Status != 4)
            //            .ToList();
            //    }
            //}
            return dataList;
        }
    }
}
