# Master Booking Status & Room Type - Feature Guide

## Quick Navigation

### Master Booking Status Module
**URL**: https://localhost:xxxx/booking-status

**Features:**
- ? View all booking statuses in a responsive table
- ? Search by Status Name (English/Hindi) or Status ID
- ? Create new booking status with bilingual support
- ? Edit existing booking status
- ? Delete (soft delete - mark as inactive) with confirmation
- ? Real-time notifications (Toastr)
- ? Loading indicators and disabled states

**Key Components:**
- `MasterBookingStatusBlazorService` - Service layer
- `MasterBookingStatusVM` - View Model
- `MasterBookingStatusDataRepository` - Data access layer
- `Index.razor` - List page
- `Create.razor` - Create page
- `Edit.razor` - Edit page

---

### Master Room Type Module
**URL**: https://localhost:xxxx/room-type

**Features:**
- ? View all room types in a responsive table
- ? Search by Room Type (English/Hindi) or Room Type ID
- ? Create new room type with bilingual support
- ? Edit existing room type
- ? Delete (soft delete - mark as inactive) with confirmation
- ? Real-time notifications (Toastr)
- ? Loading indicators and disabled states

**Key Components:**
- `MasterRoomTypeBlazorService` - Service layer
- `MasterRoomTypeVM` - View Model
- `MasterRoomTypeDataRepository` - Data access layer
- `Index.razor` - List page
- `Create.razor` - Create page
- `Edit.razor` - Edit page

---

## User Guide

### View List Page

1. Navigate to `/booking-status` or `/room-type`
2. Wait for the list to load (spinner shows while loading)
3. Table displays all active records with:
   - ID (badge)
   - English name (bold)
   - Hindi name
   - Active status (green/red badge)
   - Action buttons (Edit/Delete)

### Search Records

1. Look for the search input in the header
2. Type your search term (case-insensitive)
3. Results filter automatically after 500ms delay
4. Click the X button to clear search

### Create New Record

1. Click "Add New Status" or "Add New Room Type" button
2. Fill in the form:
   - **English Name** (required) - e.g., "Pending", "Conference Room"
   - **Hindi Name** (optional) - e.g., "?????", "??????? ????"
   - **Is Active** checkbox (checked by default)
3. Click "Save"
4. See success notification
5. Redirected to list page

### Edit Record

1. Click the yellow "Edit" button (pencil icon) on any row
2. Form loads with current data
3. Modify the fields as needed
4. Click "Update"
5. See success notification
6. Redirected to list page

### Delete Record

1. Click the red "Delete" button (trash icon) on any row
2. SweetAlert2 dialog appears asking for confirmation
3. Dialog shows the record name
4. Click "Yes, delete it!" to proceed or "Cancel" to abort
5. Record is soft deleted (marked as inactive)
6. See success notification
7. List refreshes automatically

---

## Technical Details

### Data Flow

**List Page:**
```
Component Initialization
  ?
Service.GetAllAsync()
  ?
Repository.GetAllAysnc()
  ?
EF Core Query
  ?
Filter by Status = true
  ?
Map to ViewModel
  ?
Display in Table
```

**Search:**
```
User types in search input
  ?
500ms debounce delay
  ?
Local filter applied
  ?
Table updates
```

**Create/Edit/Delete:**
```
User submits form/clicks delete
  ?
Service method called
  ?
Repository method called
  ?
Database updated
  ?
Toast notification shown
  ?
List page reloaded
```

### Service Methods

#### IMasterBookingStatusBlazorService
- `GetAllAsync()` - Get all active statuses
- `SearchAsync(string searchTerm)` - Search statuses
- `GetByIdAsync(int id)` - Get specific status
- `CreateAsync(MasterBookingStatusVM model)` - Create new
- `UpdateAsync(MasterBookingStatusVM model)` - Update existing
- `DeleteAsync(int id)` - Soft delete

#### IMasterRoomTypeBlazorService
- `GetAllAsync()` - Get all active room types
- `SearchAsync(string searchTerm)` - Search room types
- `GetByIdAsync(int id)` - Get specific room type
- `CreateAsync(MasterRoomTypeVM model)` - Create new
- `UpdateAsync(MasterRoomTypeVM model)` - Update existing
- `DeleteAsync(int id)` - Soft delete
- `FilterBySearchTerm()` - Client-side filtering

---

## Validation Rules

### Master Booking Status
- **Status Name (English)**
  - Required ?
  - Max length: 100 characters
- **Status Name (Hindi)**
  - Optional
  - Max length: 100 characters

### Master Room Type
- **Room Type (English)**
  - Required ?
  - Max length: 100 characters
- **Room Type (Hindi)**
  - Optional
  - Max length: 100 characters

---

## Error Handling

### User Sees:
- **Success**: Green toast "Record created/updated/deleted successfully!"
- **Warning**: Yellow toast "Operation failed, no changes made"
- **Error**: Red toast with error message and details

### Developer Logging:
- All operations logged to `ILogger<ComponentName>`
- Errors logged with full exception details
- Info logs for successful operations

---

## Accessibility Features

- ? DataTable keyboard navigation
- ? Bootstrap Icons for visual assistance
- ? Color-coded badges (not relying on color alone)
- ? Loading spinners for wait states
- ? ARIA labels on form inputs
- ? Disabled button states during operations
- ? Clear error messages

---

## Performance Notes

### Search Optimization
- 500ms debounce prevents excessive filtering
- Client-side filtering for instant feedback
- Local list maintained for current page

### Table Optimization
- DataTable library for server-side ready features
- Table re-initialized after data changes
- Minimal re-renders with Blazor

### Database Queries
- Single GetAllAsync() call on page load
- Filtered by Status = true (soft delete)
- Ordered by ID descending (newest first)

---

## Common Issues & Solutions

### Issue: List not showing
**Solution**: 
1. Check browser console for errors
2. Verify service is registered in Program.cs
3. Check database connection string
4. Ensure records exist and Status = true

### Issue: Search not working
**Solution**:
1. Wait 500ms after typing (debounce delay)
2. Check if records match search criteria
3. Verify case-insensitive comparison
4. Check browser console for errors

### Issue: Buttons stay disabled
**Solution**:
1. Check for JavaScript errors in console
2. Verify toastr notifications library loaded
3. Check for pending async operations
4. Refresh the page

### Issue: Delete not working
**Solution**:
1. Verify SweetAlert2 dialog appears
2. Check if "Yes, delete it!" is clicked
3. Verify database user has UPDATE permissions
4. Check database for soft delete flag (Status = false)

---

## Browser Requirements
- Modern browser with ES6 support
- JavaScript enabled
- Cookies enabled (for authentication)
- Bootstrap 5 CSS framework
- jQuery (for DataTable)

---

## Support & Maintenance

For issues or questions:
1. Check this guide first
2. Review browser console (F12)
3. Check application logs
4. Review database records directly
5. Run database migrations if needed
