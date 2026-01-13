using ConferenceHallManagement.web.Components;
using ConferenceHallManagement.Web.Services;
using ConferenceHallManagement.web.Services;
using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Repository_ConferenceHallManagement.AppDataRepositoy;
using Repository_ConferenceHallManagement.UtilityRepository;
using UoW_ConferenceHallManagement;

var builder = WebApplication.CreateBuilder(args);


// Add Razor Components with Interactive Server
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ConferenceHallManagementContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.EnableSensitiveDataLogging(builder.Environment.IsDevelopment());
}, ServiceLifetime.Scoped);

var connectionStringEmp = builder.Configuration.GetConnectionString("EmpdetConnection");
builder.Services.AddDbContext<EmpdetContext>(options =>
{
    options.UseSqlServer(connectionStringEmp);
    options.EnableSensitiveDataLogging(builder.Environment.IsDevelopment());
}, ServiceLifetime.Scoped);

// Register Repositories
builder.Services.AddScoped<IMasterBookingStatusDataRepository, MasterBookingStatusDataRepository>();
builder.Services.AddScoped<IMasterRoomTypeDataRepository, MasterRoomTypeDataRepository>();
builder.Services.AddScoped<IMasterTempEmployeeRoleDataRepository, MasterTempEmployeeRoleDataRepository>();
builder.Services.AddScoped<ICHBookingSessionsDataRepository, CHBookingSessionsDataRepository>();
builder.Services.AddScoped<ICHSessionDataRepository, CHSessionDataRepository>();
builder.Services.AddScoped<IConferenceHallBookingDataRepository, ConferenceHallBookingDataRepository>();
builder.Services.AddScoped<IConferenceHallDataRepository, ConferenceHallDataRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<Repository_ConferenceHallManagement.AppDataRepositoy.IConferenceHallDataRepository, Repository_ConferenceHallManagement.AppDataRepositoy.ConferenceHallDataRepository>();
builder.Services.AddScoped<ConferenceHallManagement.web.Services.HallConfigurationService>();

// Register Unit of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Register Blazor Services
builder.Services.AddScoped<AuthState>();
builder.Services.AddScoped<IMasterBookingStatusBlazorService, MasterBookingStatusBlazorService>();
builder.Services.AddScoped<IMasterRoomTypeBlazorService, MasterRoomTypeBlazorService>();
builder.Services.AddScoped<ITempEmployeeRoleBlazorService, TempEmployeeRoleBlazorService>();


// Register HttpClient-based services
builder.Services.AddHttpClient<MasterBookingStatusService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7001/");
});

builder.Services.AddHttpClient<MasterRoomTypeService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7001/");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
