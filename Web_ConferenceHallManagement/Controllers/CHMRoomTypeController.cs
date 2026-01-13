using AutoMapper;
using BLL_ConferenceHallManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using Web_ConferenceHallManagement.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web_ConferenceHallManagement.Controllers
{
    [Authorize(Roles = "1")]
    public class CHMRoomTypeController : Controller
    {
        private readonly ILogger<CHMRoomTypeController> _logger;
        private readonly IMapper _mapper;
        private readonly IBllCHMRoomType _bllCHMRoomType;

        public CHMRoomTypeController(ILogger<CHMRoomTypeController> logger, IMapper mapper, IBllCHMRoomType bllCHMRoomType)
        {
            _logger = logger;
            _mapper = mapper;
            _bllCHMRoomType = bllCHMRoomType;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var roomTypes = await _bllCHMRoomType.GetAllMasterRoomTypes();
                var roomTypesVM = _mapper.Map<IEnumerable<MasterCHRoomTypeVM>>(roomTypes);
                return View(roomTypesVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Index : {ex}");
                return View(new List<MasterCHRoomTypeVM>());
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomTypeEn,RoomTypeHi")] MasterCHRoomTypeVM dataVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dataAll = await _bllCHMRoomType.GetAllMasterRoomTypes();
                    var maxId = dataAll.Any() ? dataAll.Max(s => s.RoomTypeId) + 1 : 1;
                    dataVM.RoomTypeId = maxId;

                    var data = _mapper.Map<MasterRoomType>(dataVM);
                    data.Status = true;
                    data.CreatedBy = "60020656";
                    data.CreatedOn = DateTime.Now;
                    data.CreatedFrom = "::1";
                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllCHMRoomType.AddMasterRoomType(data);
                    TempData["success"] = "Status Created Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Create Post : {ex}");
                return View(dataVM);
            }

        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return NotFound();
                }

                var data = await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(id);
                if (data == null)
                {
                    TempData["error"] = "Room Type not found!";
                    return NotFound();
                }

                var dataVM = _mapper.Map<MasterCHRoomTypeVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Details : {ex}");
                return View(new MasterCHRoomTypeVM());
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return NotFound();
                }

                var data = await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(id);
                if (data == null)
                {
                    TempData["error"] = "Room Type not found!";
                    return NotFound();
                }

                var dataVM = _mapper.Map<MasterCHRoomTypeVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Edit Get : {ex}");
                return View(new MasterCHRoomTypeVM());
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomTypeId,RoomTypeEn,RoomTypeHi")] MasterCHRoomTypeVM dataVM)
        {
            try
            {
                if (id != dataVM.RoomTypeId)
                {
                    TempData["error"] = "Status not found!";
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var data = await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(id);
                    if (data == null)
                    {
                        return NotFound();
                    }
                    data.RoomTypeEn = dataVM.RoomTypeEn;
                    data.RoomTypeHi = dataVM.RoomTypeHi;

                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllCHMRoomType.UpdateMasterRoomType(data);
                    TempData["success"] = "Updated Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(dataVM);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"CHMRoomTypeController : Edit Post DbUpdateConcurrencyException: {ex}");

                if (!await MasterBookingStatusCodeExists(dataVM.RoomTypeId))
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }
                else
                {
                    TempData["error"] = "Some error occured!";
                }
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Edit Post : {ex}");
                return View(new MasterCHRoomTypeVM());
            }

        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return NotFound();
                }

                var data = await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(id);
                if (data == null)
                {
                    TempData["error"] = "Room Type not found!";
                    return NotFound();
                }

                var dataVM = _mapper.Map<MasterCHRoomTypeVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Delete Get : {ex}");
                return View(new MasterCHRoomTypeVM());
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return NotFound();
                }

                var data = await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(id);
                if (data == null)
                {
                    TempData["error"] = "Room Type not found!";
                    return NotFound();
                }

                data.Status = false;
                data.UpdatedBy = "60020656";
                data.UpdatedOn = DateTime.Now;
                data.UpdatedFrom = "::1";
                await _bllCHMRoomType.UpdateMasterRoomType(data);
                TempData["success"] = "Deleted Successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHMRoomTypeController : Delete Post : {ex}");
                return View(new MasterCHRoomTypeVM());
            }

        }

        private async Task<bool> MasterBookingStatusCodeExists(int statusId)
        {
            return await _bllCHMRoomType.GetMasterRoomTypeByRoomTypeId(statusId) != null;
        }
    }
}
