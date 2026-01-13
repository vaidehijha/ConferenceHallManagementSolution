
using BLL_ConferenceHallManagement;
using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using ProjectUtility;
using Repository_ConferenceHallManagement.AppDataRepositoy;
using Repository_ConferenceHallManagement.UtilityRepository;
using Serilog;
using System;
using UoW_ConferenceHallManagement;
using Web_ConferenceHallManagement.MappingUtility;
using Web_ConferenceHallManagement.Middlewares;

namespace Web_ConferenceHallManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Logging Service
            var _logger = new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder()
                .AddJsonFile("seri-log.config.json").Build()).Enrich.FromLogContext()
                .CreateLogger();
            builder.Logging.AddSerilog(_logger);

            // Add DataBase services.
            builder.Services.AddScoped<IMasterTempEmployeeRoleDataRepository, MasterTempEmployeeRoleDataRepository>();
            builder.Services.AddDbContext<ConferenceHallManagementContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(Consts.SqlConnection)));
            builder.Services.AddDbContext<EmpdetContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(Consts.EmpConnection)));
                        
            //All Repositories
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IMasterBookingStatusDataRepository, MasterBookingStatusDataRepository>();
            builder.Services.AddScoped<IMasterRoomTypeDataRepository, MasterRoomTypeDataRepository>();
            builder.Services.AddScoped<IConferenceHallDataRepository, ConferenceHallDataRepository>();
            builder.Services.AddScoped<ICHSessionDataRepository, CHSessionDataRepository>();
            builder.Services.AddScoped<IConferenceHallBookingDataRepository, ConferenceHallBookingDataRepository>();            
            builder.Services.AddScoped<ICHBookingSessionsDataRepository, CHBookingSessionsDataRepository>();

            //Unit of work services
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            //BLL Services
            builder.Services.AddScoped<IBllEmployee, BLLEmployee>();
            builder.Services.AddScoped<IBllCHMBookingStatus, BLLCHMBookingStatus>();
            builder.Services.AddScoped<IBllCHMRoomType, BLLCHMRoomType>();
            builder.Services.AddScoped<IBLLConferenceHall, BLLConferenceHall>();
            builder.Services.AddScoped<IBLLConferenceHallSessions, BLLConferenceHallSessions>();
            builder.Services.AddScoped<IBLLConferenceHallBookings, BLLConferenceHallBookings>();
            builder.Services.AddScoped<IBLLConferenceHallBooingSessions, BLLConferenceHallBooingSessions>();

            //add auto mapper
            builder.Services.AddAutoMapper(option=>option.AddProfile<AutoMapperProfile>());

            //cache service
            builder.Services.AddMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Set timeout
                options.Cookie.HttpOnly = true;                 // Prevent client-side access
                options.Cookie.IsEssential = true;              // Required for GDPR compliance
            });
            builder.Services.AddScoped<ICacheStorage, ObjectCacheAdapter>();
            // Add services to the container.

            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthentication("PGConferHall")
                .AddCookie("PGConferHall", options =>
                {
                    options.Cookie.Name = "PGConferHall";
                    options.LoginPath = "/";
                    options.LogoutPath = "/Login/Logout";
                    options.AccessDeniedPath = "/";

                    // Optional security options
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                    options.Cookie.SameSite = SameSiteMode.Strict;

                    options.ExpireTimeSpan = TimeSpan.FromMinutes(20); // Set cookie expiration
                    options.SlidingExpiration = true; // Enable sliding expiration
                });

            builder.Services.AddAuthorization(option =>
            {
                option.AddPolicy("SuperAdminPolicy", policy => policy.RequireRole("SuperAdmin"));
                option.AddPolicy("CentralAdminPolicy", policy => policy.RequireRole("CentralAdmin"));
                option.AddPolicy("RegionalAdminPolicy", policy => policy.RequireRole("RegionalAdmin"));
                option.AddPolicy("LocationAdminPolicy", policy => policy.RequireRole("LocationAdmin"));
                option.AddPolicy("MaintenanceAdminPolicy", policy => policy.RequireRole("MaintenanceAdmin"));
                option.AddPolicy("UserPolicy", policy => policy.RequireRole("User"));
            });

            var app = builder.Build();

            app.UseSession();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseGlobalException();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
