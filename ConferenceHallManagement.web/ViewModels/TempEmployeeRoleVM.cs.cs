using System.ComponentModel.DataAnnotations;

namespace ConferenceHallManagement.Web.ViewModels
{
    public class TempEmployeeRoleVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Number is required")]
        [StringLength(50)]
        public string EmployeeNo { get; set; } = "";

        public int ApplicationId { get; set; }

        public int RegionId { get; set; } = 1;

        public int LocationId { get; set; }

        public int DepartmentId { get; set; }

        public int RoleId { get; set; }

        public bool IsAllowWrite { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
