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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web_ConferenceHallManagement.Controllers
{
    [Authorize(Roles = "1")]
    public class ConferenceHallSessionsController : Controller
    {
        private readonly ILogger<ConferenceHallSessionsController> _logger;
        private readonly IMapper _mapper;
        private readonly IBLLConferenceHall _bllConfHall;
        private readonly IBLLConferenceHallSessions _bllConfHallSess;

        public ConferenceHallSessionsController(ILogger<ConferenceHallSessionsController> logger, IMapper mapper, IBLLConferenceHallSessions bllConfHallSess, IBLLConferenceHall bllConfHall)
        {
            _logger = logger;
            _mapper = mapper;
            _bllConfHallSess = bllConfHallSess;
            _bllConfHall = bllConfHall;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)//hall id
        {
            try
            {
                var dataList = await _bllConfHallSess.GetAllConferenceHallSessionsByHallId(id);
                var dataVM = _mapper.Map<List<ConferenceHallSessionVM>>(dataList);
                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";
                ViewBag.HallId = hallData.HallId;
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Index : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
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
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }

                var data = await _bllConfHallSess.GetConferenceHallSessionBysessionId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall Session not found!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }
                

                var dataVM = _mapper.Map<ConferenceHallSessionVM>(data);
                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}"; 

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Details : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create(int id)//hall id
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Hall Id!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }
                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(id);
                if (hallData == null)
                {
                    TempData["error"] = "Hall not found!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }

                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";

                ConferenceHallSessionVM conferenceHallSessionVM = new ConferenceHallSessionVM
                {
                    HallId = hallData.HallId,
                    SessionEn = string.Empty,
                    SessionHi = string.Empty
                };
                return View(conferenceHallSessionVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Create : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HallId,SessionEn,SessionHi")] ConferenceHallSessionVM dataVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = _mapper.Map<ConferenceHallSession>(dataVM);
                    data.Status = true;
                    data.CreatedBy = "60020656";
                    data.CreatedOn = DateTime.Now;
                    data.CreatedFrom = "::1";
                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    data.SessionId = await _bllConfHallSess.AddConferenceHallSession(data);
                    TempData["success"] = "Created Successfully.";
                    return RedirectToAction(nameof(Index), routeValues: new { id = data.HallId });
                }
                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Create Post : {ex}");
                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";
                return View(dataVM);
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
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }

                var data = await _bllConfHallSess.GetConferenceHallSessionBysessionId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall not found!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }

                var dataVM = _mapper.Map<ConferenceHallSessionVM>(data);

                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Edit Get : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SessionId,HallId,SessionEn,SessionHi")] ConferenceHallSessionVM dataVM )
        {
            try
            {
                if (id != dataVM.SessionId)
                {
                    TempData["error"] = "Invalid Id!";
                    return View(dataVM);
                }

                if (ModelState.IsValid)
                {
                    var data = await _bllConfHallSess.GetConferenceHallSessionBysessionId(id);
                    if (data == null)
                    {
                        TempData["error"] = "Data Not Found!";
                        return View(dataVM);
                    }
                    data.SessionEn = dataVM.SessionEn;
                    data.SessionHi = dataVM.SessionHi;
                    
                    data.UpdatedBy = "60020656";
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedFrom = "::1";
                    await _bllConfHallSess.UpdateConferenceHallSession(data);
                    TempData["success"] = "Updated Successfully.";
                    return RedirectToAction(nameof(Index), routeValues: new { id = data.HallId });
                }

                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";

                return View(dataVM);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"ConferenceHallSessionsController : Edit Post DbUpdateConcurrencyException: {ex}");

                if (!await ConferenceHallSessionExists(dataVM.SessionId))
                {
                    TempData["error"] = "Session not found!";
                }
                else
                {
                    TempData["error"] = "Some error occured!";
                }
                var hall = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = hall.HallNameEn;
                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Edit Post : {ex}");
                var hall = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = hall.HallNameEn;
                return View(dataVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    TempData["error"] = "Invalid Id!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }

                var data = await _bllConfHallSess.GetConferenceHallSessionBysessionId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall Session not found!";
                    return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
                }


                var dataVM = _mapper.Map<ConferenceHallSessionVM>(data);

                var hallData = await _bllConfHall.GetConferenceHallByconferenceHallId(dataVM.HallId);
                ViewBag.HallName = $"{hallData.HallNameEn} - {hallData.Floor}";

                return View(dataVM);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Delete GET : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
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

                var data = await _bllConfHallSess.GetConferenceHallSessionBysessionId(id);
                if (data == null)
                {
                    TempData["error"] = "Hall not found!";
                    return NotFound();
                }

                data.Status = false;
                data.UpdatedBy = "60020656";
                data.UpdatedOn = DateTime.Now;
                data.UpdatedFrom = "::1";
                await _bllConfHallSess.UpdateConferenceHallSession(data);
                TempData["success"] = "Deleted Successfully.";
                return RedirectToAction(nameof(Index), routeValues: new { id = data.HallId});
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"ConferenceHallSessionsController : Delete Post : {ex}");
                return RedirectToAction(nameof(Index), controllerName: "ConferenceHall");
            }
        }

        private async Task<bool> ConferenceHallSessionExists(int id)
        {
            return await _bllConfHallSess.GetConferenceHallSessionBysessionId(id) != null;
        }
    }
}
