using AutoMapper;
using BLL_ConferenceHallManagement;
using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using Repository_ConferenceHallManagement.AppDataRepositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_ConferenceHallManagement.Models;

namespace Web_ConferenceHallManagement.Controllers
{
    [Authorize(Roles = "1")]
    public class CHBookingStatusController : Controller
    {
        private readonly ILogger<CHBookingStatusController> _logger;
        private readonly IMapper _mapper;
        private readonly IBllCHMBookingStatus _bllCHMBookingStatus;

        public CHBookingStatusController(ILogger<CHBookingStatusController> logger, IMapper mapper, IBllCHMBookingStatus bllCHMBookingStatus)
        {
            _logger = logger;
            _mapper = mapper;
            _bllCHMBookingStatus = bllCHMBookingStatus;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var statuses = await _bllCHMBookingStatus.GetAllMasterBookingStatuses();
                var statusVM = _mapper.Map<IEnumerable<MasterCHBookingStatusVM>>(statuses);
                return View(statusVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Index : {ex}");
                return View(new List<MasterCHBookingStatusVM>());
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

                var masterBookingStatusCode = await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(id);
                if (masterBookingStatusCode == null)
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }

                var statusVM = _mapper.Map<MasterCHBookingStatusVM>(masterBookingStatusCode);

                return View(statusVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Details : {ex}");
                return View(new MasterCHBookingStatusVM());
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusTextEn,StatusTextHi")] MasterCHBookingStatusVM masterBookingStatusCode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var statusAll = await _bllCHMBookingStatus.GetAllMasterBookingStatuses();
                    var maxId = statusAll.Any() ? statusAll.Max(s => s.MasterBookingStatusId) + 1 : 1;
                    masterBookingStatusCode.MasterBookingStatusId = maxId;

                    var masterBookingStatusCodeEntity = _mapper.Map<MasterBookingStatusCode>(masterBookingStatusCode);
                    masterBookingStatusCodeEntity.Status = true;
                    masterBookingStatusCodeEntity.CreatedBy = "60020656";
                    masterBookingStatusCodeEntity.CreatedOn = DateTime.Now;
                    masterBookingStatusCodeEntity.CreatedFrom = "::1";
                    masterBookingStatusCodeEntity.UpdatedBy = "60020656";
                    masterBookingStatusCodeEntity.UpdatedOn = DateTime.Now;
                    masterBookingStatusCodeEntity.UpdatedFrom = "::1";
                    await _bllCHMBookingStatus.AddMasterBookingStatus(masterBookingStatusCodeEntity);
                    TempData["success"] = "Status Created Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(masterBookingStatusCode);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Create Post : {ex}");
                return View(masterBookingStatusCode);
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

                var masterBookingStatusCode = await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(id);
                if (masterBookingStatusCode == null)
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }

                var statusVM = _mapper.Map<MasterCHBookingStatusVM>(masterBookingStatusCode);
                return View(statusVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Edit Get : {ex}");
                return View(new MasterCHBookingStatusVM());
            }

        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MasterBookingStatusId,StatusTextEn,StatusTextHi")] MasterCHBookingStatusVM masterBookingStatusCode)
        {
            try
            {
                if (id != masterBookingStatusCode.MasterBookingStatusId)
                {
                    TempData["error"] = "Status not found!";
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var statusCode = await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(id);
                    if (statusCode == null)
                    {
                        return NotFound();
                    }
                    statusCode.StatusTextEn = masterBookingStatusCode.StatusTextEn;
                    statusCode.StatusTextHi = masterBookingStatusCode.StatusTextHi;

                    statusCode.UpdatedBy = "60020656";
                    statusCode.UpdatedOn = DateTime.Now;
                    statusCode.UpdatedFrom = "::1";
                    await _bllCHMBookingStatus.UpdateMasterBookingStatus(statusCode);
                    TempData["success"] = "Status Updated Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(masterBookingStatusCode);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"CHBookingStatusController : Edit Post DbUpdateConcurrencyException: {ex}");

                if (! await MasterBookingStatusCodeExists(masterBookingStatusCode.MasterBookingStatusId))
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }
                else
                {
                    TempData["error"] = "Some error occured!";
                }
                return View(masterBookingStatusCode);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Edit Post : {ex}");
                return View(new MasterCHBookingStatusVM());
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

                var masterBookingStatusCode = await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(id);
                if (masterBookingStatusCode == null)
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }

                var statusVM = _mapper.Map<MasterCHBookingStatusVM>(masterBookingStatusCode);

                return View(statusVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Delete Get : {ex}");
                return View(new MasterCHBookingStatusVM());
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

                var statusCode = await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(id);
                if (statusCode == null)
                {
                    TempData["error"] = "Booking Status not found!";
                    return NotFound();
                }

                statusCode.Status = false;
                statusCode.UpdatedBy = "60020656";
                statusCode.UpdatedOn = DateTime.Now;
                statusCode.UpdatedFrom = "::1";
                await _bllCHMBookingStatus.UpdateMasterBookingStatus(statusCode);
                TempData["success"] = "Status Deleted Successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"CHBookingStatusController : Delete Post : {ex}");
                return View(new MasterCHBookingStatusVM());
            }
            
        }

        private async Task<bool> MasterBookingStatusCodeExists(int statusId)
        {
            return await _bllCHMBookingStatus.GetMasterBookingStatusByStatusId(statusId) != null;
        }
    }
}
