using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Web_ConferenceHallManagement.Models
{
    [ValidateNever]
    public class OptionViewModel
    {
        public int Id { get; set; }           // session id
        public string Label { get; set; } = "";
        public bool IsChecked { get; set; }
        public bool IsDisabled { get; set; }
        public string? DisabledReason { get; set; }  // ✅ New
    }
    [ValidateNever]
    public class OptionGroupViewModel
    {
        public string GroupName { get; set; } = "";
        public List<OptionViewModel> Options { get; set; } = new();
    }
    
}
