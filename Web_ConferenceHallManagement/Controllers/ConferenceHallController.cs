using AutoMapper;
using BLL_ConferenceHallManagement;
using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models_ConferenceHallManagement.AppDbModels;
using Models_ConferenceHallManagement.EmpDetDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_ConferenceHallManagement.Models;

namespace Web_ConferenceHallManagement.Controllers
{
    [Authorize(Roles = "1")]
    public class ConferenceHallController : Controller
    {
        private readonly ILogger<ConferenceHallController> _logger;
        private readonly IMapper _mapper;
        private readonly IBLLConferenceHall _bllConfHall;

        public ConferenceHallController(ILogger<ConferenceHallController> logger, IMapper mapper, IBLLConferenceHall bllConfHall)
        {
            _logger = logger;
            _mapper = mapper;
            _bllConfHall = bllConfHall;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var dataList = await _bllConfHall.GetAllConferenceHalls();
                var dataVM = _mapper.Map<List<ConferenceHallVM>>(dataList);
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Index : {ex}");
                return RedirectToAction(nameof(Index));
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
                    return RedirectToAction(nameof(Index));
                }

                var data = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall not found!";
                    return RedirectToAction(nameof(Index));
                }

                var dataVM = _mapper.Map<ConferenceHallVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Details : {ex}");
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HallNameEn,HallNameHi,Floor,Capacity,RegionId,LocationId,IsApprovalRequired")] ConferenceHallVM dataVM)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    var data = _mapper.Map<ConferenceHall>(dataVM);
                    data.Status = true;
                    data.CreatedBy = "60020656";
                    data.CreatedOn = DateTime.Now;
                    data.CreatedFrom = "::1";
                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllConfHall.AddConferenceHall(data);
                    TempData["success"] = "Created Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Create Post : {ex}");
                return View(dataVM);
            }
        }

        // GET: ConferenceHall/Edit/5
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

                var data = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall not found!";
                    return RedirectToAction(nameof(Index));
                }

                var dataVM = _mapper.Map<ConferenceHallVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Edit Get : {ex}");
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ConferenceHall/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HallId,HallNameEn,HallNameHi,Floor,Capacity,RegionId,LocationId,IsApprovalRequired")] ConferenceHallVM dataVM)
        {
            try
            {
                if (id != dataVM.HallId)
                {
                    TempData["error"] = "Invalid Id!";
                    return View(dataVM);
                }

                if (ModelState.IsValid)
                {
                    var data = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                    if (data == null)
                    {
                        TempData["error"] = "Data Not Found!";
                        return View(dataVM);
                    }
                    data.HallNameEn = dataVM.HallNameEn;
                    data.HallNameHi = dataVM.HallNameHi;
                    data.Floor = dataVM.Floor;
                    data.Capacity = dataVM.Capacity;
                    data.RegionId = dataVM.RegionId;
                    data.LocationId = dataVM.LocationId;
                    data.IsApprovalRequired = dataVM.IsApprovalRequired;

                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllConfHall.UpdateConferenceHall(data);
                    TempData["success"] = "Updated Successfully.";
                    return RedirectToAction(nameof(Index));
                }
                return View(dataVM);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"ConferenceHallController : Edit Post DbUpdateConcurrencyException: {ex}");

                if (!await ConferenceHallExists(dataVM.HallId))
                {
                    TempData["error"] = "Hall not found!";
                    return View(dataVM);
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
                _logger.LogError(ex, $"ConferenceHallController : Edit Post : {ex}");
                return View(dataVM);
            }
        }

        // GET: ConferenceHall/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(Index));
                }

                var data = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                if (data == null)
                {
                    TempData["error"] = "Room Type not found!";
                    return RedirectToAction(nameof(Index));
                }

                var dataVM = _mapper.Map<ConferenceHallVM>(data);

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Delete Get : {ex}");
                return View(new ConferenceHallVM());
            }
        }

        // POST: ConferenceHall/Delete/5
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

                var data = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall not found!";
                    return NotFound();
                }

                data.Status = false;
                data.UpdatedBy = "60020656";
                data.UpdatedOn = DateTime.Now;
                data.UpdatedFrom = "::1";
                await _bllConfHall.UpdateConferenceHall(data);
                TempData["success"] = "Deleted Successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallController : Delete Post : {ex}");
                return View(new ConferenceHallVM());
            }
        }

        private async Task<bool> ConferenceHallExists(int id)
        {
            return await _bllConfHall.GetConferenceHallByconferenceHallId(id) != null;
        }
    }
}
