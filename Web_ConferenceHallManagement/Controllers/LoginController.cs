using AutoMapper;
using BLL_ConferenceHallManagement;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models_ConferenceHallManagement.AppDbModels;
using Models_ConferenceHallManagement.EmpDetDbModels;
using Repository_ConferenceHallManagement.AppDataRepositoy;
using Repository_ConferenceHallManagement.UtilityRepository;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Web_ConferenceHallManagement.Models;

namespace Web_ConferenceHallManagement.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IMapper _mapper;
        private readonly IBllEmployee _bllEmp;

        public LoginController(ILogger<LoginController> logger, IMapper mapper, IBllEmployee bllEmp)
        {
            _logger = logger;
            _mapper = mapper;
            _bllEmp = bllEmp;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync("PGConferHall");
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Step 1: Authenticate user
                    var isAuthenticated = await _bllEmp.AuthenticateUser(loginVM.UserName, loginVM.Password);
                    if (!isAuthenticated)
                    {
                        TempData["error"] = "Please check User Name Or Password!";
                        return View(loginVM);
                    }

                    // Step 2: Get employee details
                    var emp = await _bllEmp.GetEmployeeByUserName(loginVM.UserName);
                    if (emp == null)
                    {
                        TempData["error"] = "Employee details not found!";
                        return View(loginVM);
                    }

                    // Step 3: Get roles
                    var empRoles = await _bllEmp.GetEmployeeRoles(emp.EightDigitEmpNo);

                    // Step 4: Create CLAIMS (SIR KA EXACT CODE)
                    var claims = new List<Claim>
                    {
                        new Claim("EmpNo", emp.EightDigitEmpNo.ToString()),
                        new Claim("guid", emp.Empimgguid.ToString()),
                        new Claim(ClaimTypes.Name, emp.Empname ?? "Demo User"),
                        new Claim(ClaimTypes.Email, emp.Pgemail ?? ""),
                        new Claim(ClaimTypes.MobilePhone, emp.Cellno ?? "")
                    };

                    // Add roles
                    if (empRoles != null && empRoles.Any())
                    {
                        foreach (var role in empRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role.RoleId.ToString()));
                        }
                    }

                    // Step 5: SignIn
                    var identity = new ClaimsIdentity(claims, "PGConferHall");
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("PGConferHall", principal);

                    // Step 6: Session mein user save
                    HttpContext.Session.SetString("User", JsonSerializer.Serialize(emp));

                    TempData["success"] = "Login Successfully.";
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error, Please try again later!";
                _logger.LogError(ex, $"LoginController : Login Post : {ex}");
            }

            return View(loginVM);
        }
    }
}
