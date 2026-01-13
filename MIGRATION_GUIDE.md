# Database Migration Guide for TempEmployeeRole

## Prerequisites
- The DbSet `TempEmployeeRoles` is already added to `ConferenceHallManagementContext`
- The entity `TempEmployeeRole` is already configured in `OnModelCreating`
- Entity Framework Core tools are installed

## Check if Table Exists

Run this SQL query in your database:
```sql
SELECT * FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = 'TempEmployeeRoles'
```

If the table exists, you don't need to run migrations.

## If Table Does NOT Exist - Run Migration

### Option 1: Using Package Manager Console (Visual Studio)

1. Open **Tools** ? **NuGet Package Manager** ? **Package Manager Console**

2. Select the **DAL_ConferenceHallManagement** project from the dropdown

3. Run these commands:
```powershell
Add-Migration Add_TempEmployeeRole -Context ConferenceHallManagementContext
Update-Database -Context ConferenceHallManagementContext
```

### Option 2: Using .NET CLI

Open terminal/command prompt and navigate to solution directory:

```bash
# Add migration
dotnet ef migrations add Add_TempEmployeeRole --project DAL_ConferenceHallManagement --startup-project ConferenceHallManagement.web --context ConferenceHallManagementContext

# Update database
dotnet ef database update --project DAL_ConferenceHallManagement --startup-project ConferenceHallManagement.web --context ConferenceHallManagementContext
```

## What the Migration Creates

The migration will create a table with this structure:

```sql
CREATE TABLE [dbo].[TempEmployeeRoles](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [EmpNo] [nvarchar](50) NOT NULL,
    [ApplicationId] [int] NOT NULL,
    [RegionId] [int] NOT NULL,
    [LocationId] [int] NOT NULL,
    [DepartmentId] [int] NOT NULL,
    [RoleId] [int] NOT NULL,
    [IsAllowWrite] [bit] NOT NULL,
    [Status] [bit] NOT NULL DEFAULT(1),
    [CreatedBy] [nvarchar](50) NOT NULL,
    [CreatedOn] [datetime2] NOT NULL,
    [CreatedFrom] [nvarchar](50) NOT NULL,
    [UpdatedBy] [nvarchar](50) NOT NULL,
    [UpdatedOn] [datetime2] NOT NULL,
    [UpdatedFrom] [nvarchar](50) NOT NULL,
    CONSTRAINT [PK_TempEmployeeRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
)
```

## Verify Migration Success

After running the migration, verify the table was created:

```sql
-- Check table exists
SELECT * FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = 'TempEmployeeRoles'

-- Check columns
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'TempEmployeeRoles'
ORDER BY ORDINAL_POSITION

-- Insert test data
INSERT INTO TempEmployeeRoles 
(EmpNo, ApplicationId, RegionId, LocationId, DepartmentId, RoleId, IsAllowWrite, Status, CreatedBy, CreatedOn, CreatedFrom, UpdatedBy, UpdatedOn, UpdatedFrom)
VALUES 
('EMP001', 1, 1, 1, 0, 1, 1, 1, 'System', GETDATE(), 'Migration', 'System', GETDATE(), 'Migration')

-- Query test data
SELECT * FROM TempEmployeeRoles
```

## Connection String

Make sure your `appsettings.json` has the correct connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ConferenceHallManagement;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
```

## Troubleshooting

### Error: "Build failed"
- Solution: Build the entire solution first
- Run: `dotnet build`

### Error: "A network-related or instance-specific error"
- Solution: Check SQL Server is running
- Verify connection string is correct

### Error: "Unable to create an object of type 'ConferenceHallManagementContext'"
- Solution: Make sure startup project is set correctly
- Use `--startup-project ConferenceHallManagement.web` flag

### Error: "The entity type 'TempEmployeeRole' requires a primary key"
- This shouldn't happen as Id is already configured as primary key
- If it does, verify the entity model has `[Key]` attribute or is configured in OnModelCreating

## Manual Table Creation (If Migrations Fail)

If migrations fail, you can create the table manually:

```sql
CREATE TABLE [dbo].[TempEmployeeRoles](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [EmpNo] [nvarchar](50) NOT NULL,
    [ApplicationId] [int] NOT NULL,
    [RegionId] [int] NOT NULL,
    [LocationId] [int] NOT NULL,
    [DepartmentId] [int] NOT NULL,
    [RoleId] [int] NOT NULL,
    [IsAllowWrite] [bit] NOT NULL,
    [Status] [bit] NOT NULL DEFAULT(1),
    [CreatedBy] [nvarchar](50) NOT NULL,
    [CreatedOn] [datetime2](7) NOT NULL,
    [CreatedFrom] [nvarchar](50) NOT NULL,
    [UpdatedBy] [nvarchar](50) NOT NULL,
    [UpdatedOn] [datetime2](7) NOT NULL,
    [UpdatedFrom] [nvarchar](50) NOT NULL
)
GO
```

## After Migration

1. Build the solution: ? DONE
2. Run the application
3. Navigate to `/masters/temployee`
4. Test CRUD operations
5. Check database to verify records are being created/updated

## Notes

- The table uses **soft deletes** (Status = false, not actual delete)
- All operations are logged
- RegionId defaults to 1 (Corporate Centre)
- Status defaults to true (Active)
