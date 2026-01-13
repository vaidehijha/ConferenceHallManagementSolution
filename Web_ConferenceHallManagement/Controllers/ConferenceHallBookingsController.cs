using AutoMapper;
using BLL_ConferenceHallManagement;
using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models_ConferenceHallManagement.AppDbModels;
using Models_ConferenceHallManagement.EmpDetDbModels;
using Mono.TextTemplating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UoW_ConferenceHallManagement;
using Web_ConferenceHallManagement.Models;

namespace Web_ConferenceHallManagement.Controllers
{
    [Authorize]
    public class ConferenceHallBookingsController : Controller
    {
        private readonly ILogger<ConferenceHallBookingsController> _logger;
        private readonly IMapper _mapper;
        private readonly IBLLConferenceHallBookings _bllConfHallBook;
        private readonly IBLLConferenceHall _bllConfHall;
        private readonly IBllCHMRoomType _bllRoomType;
        private readonly IUnitOfWork _unitOfWork;

        public ConferenceHallBookingsController(ILogger<ConferenceHallBookingsController> logger, IMapper mapper, IBLLConferenceHallBookings bllConfHallBook, IBLLConferenceHall bllConfHall, IBllCHMRoomType bllRoomType, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _mapper = mapper;
            _bllConfHallBook = bllConfHallBook;
            _bllConfHall = bllConfHall;
            _bllRoomType = bllRoomType;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var dataList = await _bllConfHallBook.GetAllConferenceHallBookings();
                var dataVM = _mapper.Map<List<ConferenceHallBookingVM>>(dataList);
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Index : {ex}");
                return RedirectToAction(nameof(Index));
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> AdminIndex()
        {
            try
            {
                var dataList = await _bllConfHallBook.GetAllConferenceHallBookings();
                var dataVM = _mapper.Map<List<ConferenceHallBookingVM>>(dataList);
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Index : {ex}");
                return RedirectToAction(nameof(Index));
            }

        }

        //// GET: ConferenceHallBookings/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var conferenceHallBooking = await _context.ConferenceHallBookings
        //        .Include(c => c.Hall)
        //        .Include(c => c.RoomType)
        //        .Include(c => c.StatusNavigation)
        //        .FirstOrDefaultAsync(m => m.BookingId == id);
        //    if (conferenceHallBooking == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(conferenceHallBooking);
        //}

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await SetHallAndRoomTypeDD();
            ConferenceHallBookingVM vm = new ConferenceHallBookingVM();
            vm.StartDate = DateTime.Now;
            vm.EndDate = DateTime.Now;
            vm.Groups = new List<OptionGroupViewModel>();
            return View(vm);
            //return View();
        }
        protected async Task SetHallAndRoomTypeDD(int hallId = 0, int roomTypeId = 0)
        {
            //Hall Dropdown
            var hallList = await _bllConfHall.GetAllConferenceHalls();
            if (hallList != null && hallList.Any())
            {
                Dictionary<int, string> hallDictionary = new Dictionary<int, string>();
                foreach (var hall in hallList)
                {
                    hallDictionary.Add(hall.HallId, $"{hall.HallNameEn} ({hall.HallNameHi}) - {hall.Floor} - {hall.Capacity}");
                }
                ViewData["HallId"] = new SelectList(hallDictionary, "Key", "Value", hallId);
            }
            
            //Roomtype Dropdown
            var roomTypeList = await _bllRoomType.GetAllMasterRoomTypes();
            if (roomTypeList != null && roomTypeList.Any())
            {
                Dictionary<int, string> roomTypeDictionary = new Dictionary<int, string>();
                foreach (var roomType in roomTypeList)
                {
                    roomTypeDictionary.Add(roomType.RoomTypeId, $"{roomType.RoomTypeEn} ({roomType.RoomTypeHi})");
                }
                ViewData["RoomTypeId"] = new SelectList(roomTypeDictionary, "Key", "Value", roomTypeId);
            }           
            
        }

        [HttpGet]
        public async Task<JsonResult> GetHallSessions(int hallId)
        {
            var filteredSessions = await _unitOfWork.CHSessionDataRepository.GetConferenceHallSessionByHallId(hallId);
            return Json(filteredSessions);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HallId,RoomTypeId,StartDate,EndDate,ProgramName,NoOfAttendees,Remarks,Groups")] ConferenceHallBookingVM dataVM)
        {
            try
            {
                if (ModelState.IsValid)
                {                   
                    if(!ValidateBookingForm(dataVM))
                    {
                        TempData["error"] = "Please fill all required fields correctly!";
                        await SetHallAndRoomTypeDD();
                        return View(dataVM);
                    }
                    
                    if(dataVM.Groups == null || dataVM.Groups.Count == 0)
                    {
                        dataVM.Groups = new List<OptionGroupViewModel>();

                        IEnumerable<DateTime> dateRange = Enumerable.Range(0, (dataVM.EndDate - dataVM.StartDate).Days + 1).Select(offset => dataVM.StartDate.AddDays(offset));
                        foreach (var date in dateRange)
                        {
                            OptionGroupViewModel group = new OptionGroupViewModel();
                            group.GroupName = date.ToString("ddd, dd-MMM-yyyy");

                            var filteredSessions = await _unitOfWork.CHSessionDataRepository.GetConferenceHallSessionByHallId(dataVM.HallId);
                            if(filteredSessions != null && filteredSessions.Count() > 0)
                            {
                                //group.Options = filteredSessions.Select(x=>x.SessionEn).ToList();
                                group.Options = new List<OptionViewModel>();
                                foreach (var session in filteredSessions)
                                {
                                    var sessionBookingCheck = await _unitOfWork.CHBookingSessionsDataRepository.GetConferenceHallSessionBookingDetails(session.HallId, session.SessionId, date);

                                    OptionViewModel optionViewModel = new OptionViewModel();
                                    optionViewModel.Id = session.SessionId;
                                    optionViewModel.Label = session.SessionEn;
                                    optionViewModel.IsDisabled = sessionBookingCheck == null ? false : true;
                                    var bookedBy = optionViewModel.IsDisabled ? $"Booked By {sessionBookingCheck?.CreatedBy}" : "";
                                    optionViewModel.DisabledReason = bookedBy;
                                    group.Options.Add(optionViewModel);
                                }
                            }
                            dataVM.Groups.Add(group);
                        }
                        await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                        return View(dataVM);
                    }

                    var groups = dataVM.Groups;
                    var count = 0;
                    foreach(var group in groups)
                    {
                        if (group.Options.Any(x => x.IsChecked))
                        {
                            count += 1;
                        }
                    }
                    if(count == 0)
                    {
                        await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                        TempData["error"] = "Select minimum 1 session to create booking!";
                        return View(dataVM);
                    }

                    var data = _mapper.Map<ConferenceHallBooking>(dataVM);
                    //check for hall configuration for approval Manual Approval/Auto Approval
                    data.Status = 5;//Auto Approval
                    data.CreatedBy = "60020656";
                    data.CreatedOn = DateTime.Now;
                    data.CreatedFrom = "::1";
                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    var entryId = await _bllConfHallBook.AddConferenceHallBooking(data);
                    if(entryId > 0)
                    {
                        foreach (var group in groups)
                        {
                            foreach(var option in group.Options)
                            {
                                if (option.IsChecked)
                                {
                                    var bookingSession = new ConferenceHallBookingSession
                                    {
                                        BookingId = entryId,
                                        HallId = data.HallId,
                                        SessionId = option.Id,
                                        BookingDate = Convert.ToDateTime(group.GroupName),
                                        Status = data.Status,
                                        CreatedBy = "60020656",
                                        CreatedOn = DateTime.Now,
                                        CreatedFrom = "::1",
                                        UpdatedBy = "60020656",
                                        UpdatedOn = DateTime.Now,
                                        UpdatedFrom = "::1"
                                    };
                                    _unitOfWork.CHBookingSessionsDataRepository.Add(bookingSession);
                                }
                            }
                        }
                        await _unitOfWork.SaveChangesAsync();
                        TempData["success"] = $"{count} bookings Created Successfully.";
                        return RedirectToAction(nameof(Index));
                    }
                    await SetHallAndRoomTypeDD();
                    return View(dataVM);
                }
                await SetHallAndRoomTypeDD();
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Create Post : {ex}");
                await SetHallAndRoomTypeDD();
                return View(dataVM);
            }
            
        }
        protected bool ValidateBookingForm(ConferenceHallBookingVM dataVM)
        {
            var isValid = dataVM.HallId != 0 && dataVM.RoomTypeId != 0 &&
                          dataVM.StartDate != default(DateTime) && dataVM.EndDate != default(DateTime) &&
                          !string.IsNullOrEmpty(dataVM.ProgramName) && dataVM.NoOfAttendees > 0;
            return isValid;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(Index));
                }

                var data = await _bllConfHallBook.GetConferenceHallBookingBybookingId(id);

                if (data == null)
                {
                    TempData["error"] = "Booking data not found!";
                    return RedirectToAction(nameof(Index));
                }
                var dataVM = _mapper.Map<ConferenceHallBookingVM>(data);
                await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Edit Get : {ex}");
                return RedirectToAction(nameof(Index));
            }
            
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,RoomTypeId,ProgramName,NoOfAttendees,Remarks")] ConferenceHallBookingVM dataVM)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                    return View(dataVM);
                }
                if (id != dataVM.BookingId)
                {
                    TempData["error"] = "Invalid Id!";
                    await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                    return View(dataVM);
                }
                if (ModelState.IsValid)
                {
                    var data = await _bllConfHallBook.GetConferenceHallBookingBybookingId(id);
                    if (data == null)
                    {
                        TempData["error"] = "Data Not Found!";
                        await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                        return View(dataVM);
                    }
                    data.RoomTypeId = dataVM.RoomTypeId;
                    data.ProgramName = dataVM.ProgramName;
                    data.NoOfAttendees = dataVM.NoOfAttendees;
                    data.Remarks = dataVM.Remarks;

                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllConfHallBook.UpdateConferenceHallBooking(data);
                    TempData["success"] = "Updated Successfully.";
                    return RedirectToAction(nameof(Index));

                }
                await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                return View(dataVM);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"ConferenceHallBookingsController : Edit Post DbUpdateConcurrencyException: {ex}");

                if (!await ConferenceHallBookingExists(dataVM.BookingId))
                {
                    TempData["error"] = "Booking not found!";
                }
                else
                {
                    TempData["error"] = "Some error occured!";
                }
                await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Edit Post : {ex}");
                await SetHallAndRoomTypeDD(dataVM.HallId, dataVM.RoomTypeId);
                return View(dataVM);
            }
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(Index));
                }
                var conferenceHallBooking = await _unitOfWork.ConferenceHallBookingDataRepository.GetByIdAysnc(id);

                if (conferenceHallBooking == null)
                {
                    TempData["error"] = "Booking not found!";
                    return RedirectToAction(nameof(Index));
                }

                // Set the status to 3 (assuming 3 is the status for cancellation)
                conferenceHallBooking.Status = 3;
                conferenceHallBooking.UpdatedBy = "60020656";
                conferenceHallBooking.UpdatedOn = DateTime.Now;
                conferenceHallBooking.UpdatedFrom = "::1";
                _unitOfWork.ConferenceHallBookingDataRepository.Update(conferenceHallBooking);

                // Update all related booking sessions
                var bookingSessions = await _unitOfWork.CHBookingSessionsDataRepository.GetConferenceHallSessionBookingDetailsByBookingId(id);
                if (bookingSessions != null && bookingSessions.Any())
                {
                    foreach (var session in bookingSessions)
                    {
                        session.Status = 3; // Assuming 3 is the status for cancellation
                        session.UpdatedBy = "60020656";
                        session.UpdatedOn = DateTime.Now;
                        session.UpdatedFrom = "::1";
                        _unitOfWork.CHBookingSessionsDataRepository.Update(session);
                    }
                }
                await _unitOfWork.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : DeleteConfirmed Post : {ex}");
                return RedirectToAction(nameof(Index));
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSession([FromRoute] int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(Index));
                }
                var conferenceHallBookingSession = await _unitOfWork.CHBookingSessionsDataRepository.GetByIdAysnc(id);

                if (conferenceHallBookingSession == null)
                {
                    TempData["error"] = "Booking Session not found!";
                    return RedirectToAction(nameof(Index));
                }

                var allBookedSessions = await _unitOfWork.CHBookingSessionsDataRepository.GetConferenceHallSessionBookingDetailsByBookingId(conferenceHallBookingSession.BookingId);
                if(allBookedSessions?.Count() <= 1)
                {
                    TempData["error"] = "Last session booking can not cancelled, please try delete booking in My Bookings Tab --> Delete!";
                    return RedirectToAction(nameof(Edit), new { id = conferenceHallBookingSession.BookingId });
                }

                conferenceHallBookingSession.Status = 3;
                conferenceHallBookingSession.UpdatedBy = "60020656";
                conferenceHallBookingSession.UpdatedOn = DateTime.Now;
                conferenceHallBookingSession.UpdatedFrom = "::1";
                _unitOfWork.CHBookingSessionsDataRepository.Update(conferenceHallBookingSession);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { id = conferenceHallBookingSession.BookingId });

            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : DeleteSession Post : {ex}");
                return RedirectToAction(nameof(Index));
            }
        }

        private async Task<bool> ConferenceHallBookingExists(int id)
        {
            return await _unitOfWork.ConferenceHallBookingDataRepository.GetByIdAysnc(id) != null;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Approve([FromRoute] int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(AdminIndex));
                }
                var conferenceHallBooking = await _unitOfWork.ConferenceHallBookingDataRepository.GetByIdAysnc(id);

                if (conferenceHallBooking == null)
                {
                    TempData["error"] = "Booking not found!";
                    return RedirectToAction(nameof(AdminIndex));
                }

                // Set the status to 3 (assuming 3 is the status for cancellation)
                conferenceHallBooking.Status = 2;
                conferenceHallBooking.UpdatedBy = "60020656";
                conferenceHallBooking.UpdatedOn = DateTime.Now;
                conferenceHallBooking.UpdatedFrom = "::1";
                _unitOfWork.ConferenceHallBookingDataRepository.Update(conferenceHallBooking);

                // Update all related booking sessions
                var bookingSessions = await _unitOfWork.CHBookingSessionsDataRepository.GetConferenceHallSessionBookingDetailsByBookingId(id);
                if (bookingSessions != null && bookingSessions.Any())
                {
                    foreach (var session in bookingSessions)
                    {
                        session.Status = 1; // Approved status
                        session.UpdatedBy = "60020656";
                        session.UpdatedOn = DateTime.Now;
                        session.UpdatedFrom = "::1";
                        _unitOfWork.CHBookingSessionsDataRepository.Update(session);
                    }
                }
                await _unitOfWork.SaveChangesAsync();
                TempData["success"] = "Approved Successfully.";
                return RedirectToAction(nameof(AdminIndex));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Approve Post : {ex}");
                return RedirectToAction(nameof(AdminIndex));
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reject([FromRoute] int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(AdminIndex));
                }
                var conferenceHallBooking = await _unitOfWork.ConferenceHallBookingDataRepository.GetByIdAysnc(id);

                if (conferenceHallBooking == null)
                {
                    TempData["error"] = "Booking not found!";
                    return RedirectToAction(nameof(AdminIndex));
                }

                // Set the status to 3 (assuming 3 is the status for cancellation)
                conferenceHallBooking.Status = 4;
                conferenceHallBooking.UpdatedBy = "60020656";
                conferenceHallBooking.UpdatedOn = DateTime.Now;
                conferenceHallBooking.UpdatedFrom = "::1";
                _unitOfWork.ConferenceHallBookingDataRepository.Update(conferenceHallBooking);

                // Update all related booking sessions
                var bookingSessions = await _unitOfWork.CHBookingSessionsDataRepository.GetConferenceHallSessionBookingDetailsByBookingId(id);
                if (bookingSessions != null && bookingSessions.Any())
                {
                    foreach (var session in bookingSessions)
                    {
                        session.Status = 4; // reject status
                        session.UpdatedBy = "60020656";
                        session.UpdatedOn = DateTime.Now;
                        session.UpdatedFrom = "::1";
                        _unitOfWork.CHBookingSessionsDataRepository.Update(session);
                    }
                }
                await _unitOfWork.SaveChangesAsync();
                TempData["success"] = "Rejected Successfully.";
                return RedirectToAction(nameof(AdminIndex));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallBookingsController : Reject Post : {ex}");
                return RedirectToAction(nameof(AdminIndex));
            }

        }
    }
}
