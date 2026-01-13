# Quick Reference - Master Booking Status & Room Type

## ?? Quick Start

### Access the Modules
```
Master Booking Status: https://localhost:xxxx/booking-status
Master Room Type:      https://localhost:xxxx/room-type
```

### File Locations
```
ViewModels:
  ?? ConferenceHallManagement.web\ViewModels\
     ?? MasterBookingStatusVM.cs
     ?? MasterRoomTypeVM.cs

Services:
  ?? ConferenceHallManagement.web\Services\
     ?? MasterBookingStatusBlazorService.cs
     ?? MasterRoomTypeBlazorService.cs

Pages:
  ?? ConferenceHallManagement.web\Components\Pages\Masters\
     ?? BookingStatus\
     ?  ?? Index.razor
     ?  ?? Create.razor
     ?  ?? Edit.razor
     ?? RoomType\
        ?? Index.razor
        ?? Create.razor
        ?? Edit.razor

Repositories:
  ?? Repository_ConferenceHallManagement\AppDataRepositoy\
     ?? MasterBookingStatusDataRepository.cs
     ?? MasterRoomTypeDataRepository.cs
```

---

## ?? Complete Routes Reference

### Master Booking Status
| Action | Route | Page |
|--------|-------|------|
| List | `/booking-status` | Index.razor |
| List Alt | `/masters/booking-status` | Index.razor |
| Create | `/booking-status/create` | Create.razor |
| Create Alt | `/masters/booking-status/create` | Create.razor |
| Edit | `/booking-status/edit/{id}` | Edit.razor |
| Edit Alt | `/masters/booking-status/edit/{id}` | Edit.razor |

### Master Room Type
| Action | Route | Page |
|--------|-------|------|
| List | `/room-type` | Index.razor |
| List Alt | `/masters/room-type` | Index.razor |
| Create | `/room-type/create` | Create.razor |
| Create Alt | `/masters/room-type/create` | Create.razor |
| Edit | `/room-type/edit/{id}` | Edit.razor |
| Edit Alt | `/masters/room-type/edit/{id}` | Edit.razor |

---

## ?? Service Methods

### MasterBookingStatusBlazorService
```csharp
Task<IEnumerable<MasterBookingStatusVM>> GetAllAsync()
Task<IEnumerable<MasterBookingStatusVM>> SearchAsync(string searchTerm)
Task<MasterBookingStatusVM?> GetByIdAsync(int id)
Task<int> CreateAsync(MasterBookingStatusVM model)
Task<int> UpdateAsync(MasterBookingStatusVM model)
Task<int> DeleteAsync(int id)
```

### MasterRoomTypeBlazorService
```csharp
Task<IEnumerable<MasterRoomTypeVM>> GetAllAsync()
Task<IEnumerable<MasterRoomTypeVM>> SearchAsync(string searchTerm)
Task<MasterRoomTypeVM?> GetByIdAsync(int id)
Task<int> CreateAsync(MasterRoomTypeVM model)
Task<int> UpdateAsync(MasterRoomTypeVM model)
Task<int> DeleteAsync(int id)
IEnumerable<MasterRoomTypeVM> FilterBySearchTerm(IEnumerable<MasterRoomTypeVM> list, string term)
```

---

## ?? Data Models

### MasterBookingStatusVM
```csharp
public class MasterBookingStatusVM
{
    public int Id { get; set; }
    public int StatusId { get; set; }
    public string StatusName { get; set; }          // Required
    public string StatusNameHindi { get; set; }    // Optional
    public bool IsActive { get; set; }
}
```

### MasterRoomTypeVM
```csharp
public class MasterRoomTypeVM
{
    public int Id { get; set; }
    public int RoomTypeId { get; set; }
    public string RoomTypeEn { get; set; }         // Required
    public string RoomTypeHi { get; set; }         // Optional
    public bool IsActive { get; set; }
}
```

---

## ?? Common Operations

### Display a List
```csharp
var items = await Service.GetAllAsync();
```

### Search Records
```csharp
var results = await Service.SearchAsync("conference");
```

### Get Single Record
```csharp
var item = await Service.GetByIdAsync(1);
```

### Create New Record
```csharp
var model = new MasterBookingStatusVM 
{ 
    StatusName = "Pending",
    StatusNameHindi = "?????",
    IsActive = true
};
var result = await Service.CreateAsync(model);
```

### Update Existing Record
```csharp
model.StatusName = "Updated Name";
var result = await Service.UpdateAsync(model);
```

### Delete (Soft Delete)
```csharp
var result = await Service.DeleteAsync(id);
```

---

## ?? UI Components Overview

### Index Page (List View)
- **Header**: Title + Add New button
- **Search**: Debounced search input (500ms)
- **Table**: DataTable with columns
  - ID (badge)
  - Name (English)
  - Name (Hindi)
  - Status (active/inactive)
  - Actions (Edit/Delete)
- **Loading**: Spinner while loading
- **Empty**: Message when no results

### Create/Edit Page (Form)
- **Header**: Title indicating create/edit
- **Form Fields**:
  - Name (English) - Required
  - Name (Hindi) - Optional
  - Is Active - Checkbox
- **Buttons**: Cancel + Save/Update
- **Validation**: Real-time validation messages
- **Loading**: Spinner on submit

---

## ?? Data Flow Diagrams

### Read Flow
```
User Views List
  ?
Component OnInitialized
  ?
Service.GetAllAsync()
  ?
Repository.GetAllAsync()
  ?
EF Core Query (Status = true)
  ?
Map to ViewModels
  ?
Display in Table
```

### Create Flow
```
User Fills Form
  ?
Form Validation
  ?
User Clicks Save
  ?
Service.CreateAsync(model)
  ?
Repository.Add(entity)
  ?
Database Insert
  ?
Toast Notification
  ?
Redirect to List
```

### Update Flow
```
User Clicks Edit
  ?
Service.GetByIdAsync(id)
  ?
Form Loads with Data
  ?
User Modifies Fields
  ?
User Clicks Update
  ?
Service.UpdateAsync(model)
  ?
Repository.Update(entity)
  ?
Database Update
  ?
Toast Notification
  ?
Redirect to List
```

### Delete Flow
```
User Clicks Delete
  ?
SweetAlert2 Confirmation
  ?
User Confirms
  ?
Service.DeleteAsync(id)
  ?
Repository.Update(entity, Status=false)
  ?
Database Update (Soft Delete)
  ?
Toast Notification
  ?
List Refreshes
```

---

## ?? Testing Commands

### Run Application
```bash
dotnet run --project ConferenceHallManagement.web
```

### Build Solution
```bash
dotnet build
```

### Clean Build
```bash
dotnet clean
dotnet build
```

### Run Tests (if available)
```bash
dotnet test
```

---

## ?? Mobile Friendly Features

- ? Responsive table layout
- ? Mobile-optimized buttons
- ? Stack vertically on small screens
- ? Touch-friendly controls
- ? Readable on small screens
- ? Fast load times

---

## ?? Learning Resources

### For Understanding the Code
1. Repository Pattern - Data access abstraction
2. Service Pattern - Business logic layer
3. ViewModel Pattern - Data presentation
4. MVVM - Model-View-ViewModel architecture
5. Blazor - Interactive web UI with .NET

### Key Files to Study
1. `MasterBookingStatusBlazorService.cs` - Service implementation
2. `MasterBookingStatusDataRepository.cs` - Data access
3. `Index.razor` - List UI with search
4. `Create.razor` - Form creation
5. `Edit.razor` - Form editing

---

## ?? Debugging Tips

### Enable Logging
```csharp
builder.Logging.AddConsole();
builder.Logging.AddDebug();
```

### Check Browser Console
Press F12 ? Console tab to see JavaScript errors

### Check Application Logs
Look for ILogger output in console or debug window

### Database Inspection
Connect to SQL Server and query:
```sql
SELECT * FROM MasterBookingStatusCodes WHERE Status = 1
SELECT * FROM MasterRoomTypes WHERE Status = 1
```

### Verify Services Registered
Check Program.cs for:
```csharp
builder.Services.AddScoped<IMasterBookingStatusBlazorService, ...>();
builder.Services.AddScoped<IMasterRoomTypeBlazorService, ...>();
```

---

## ?? Database Schema (Reference)

### MasterBookingStatusCodes Table
```sql
Id (int, PK)
MasterBookingStatusId (int, unique)
StatusTextEn (nvarchar(100))
StatusTextHi (nvarchar(100))
Status (bit)
CreatedBy (nvarchar)
CreatedOn (datetime)
CreatedFrom (nvarchar)
UpdatedBy (nvarchar)
UpdatedOn (datetime)
UpdatedFrom (nvarchar)
```

### MasterRoomTypes Table
```sql
Id (int, PK)
RoomTypeId (int, unique)
RoomTypeEn (nvarchar(100))
RoomTypeHi (nvarchar(100))
Status (bit)
CreatedBy (nvarchar)
CreatedOn (datetime)
CreatedFrom (nvarchar)
UpdatedBy (nvarchar)
UpdatedOn (datetime)
UpdatedFrom (nvarchar)
```

---

## ?? Configuration (Program.cs)

```csharp
// DbContext
builder.Services.AddDbContext<ConferenceHallManagementContext>(options =>
    options.UseSqlServer(connectionString));

// Repositories
builder.Services.AddScoped<IMasterBookingStatusDataRepository, ...>();
builder.Services.AddScoped<IMasterRoomTypeDataRepository, ...>();

// Services
builder.Services.AddScoped<IMasterBookingStatusBlazorService, ...>();
builder.Services.AddScoped<IMasterRoomTypeBlazorService, ...>();

// Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
```

---

## ?? Dependencies

### NuGet Packages Required
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Components.Web
- Microsoft.AspNetCore.Components.WebAssembly

### JavaScript Libraries (CDN)
- Bootstrap 5 CSS
- Bootstrap Icons
- jQuery
- DataTables
- Toastr.js
- SweetAlert2

---

## ? Features Summary

| Feature | Status | Notes |
|---------|--------|-------|
| List View | ? | With DataTable support |
| Search | ? | 500ms debounce |
| Create | ? | Form validation |
| Edit | ? | Load existing data |
| Delete | ? | Soft delete with confirmation |
| Bilingual | ? | English & Hindi |
| Notifications | ? | Toastr notifications |
| Validation | ? | Server & client-side |
| Responsive | ? | Mobile friendly |
| Error Handling | ? | Comprehensive |

---

## ?? Status Dashboard

| Component | Status | Last Check |
|-----------|--------|------------|
| Build | ? Successful | Now |
| Master Booking Status | ? Working | Now |
| Master Room Type | ? Working | Now |
| Database | ? Connected | Now |
| Services | ? Registered | Now |
| Routes | ? Configured | Now |

---

**Last Updated**: $(date)
**Version**: 1.0
**Status**: Production Ready ?
