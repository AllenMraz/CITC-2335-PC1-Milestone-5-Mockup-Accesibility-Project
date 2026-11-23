using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Milestone_5_Mockup
{
    public class DatabaseItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        public string ItemName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Item Version is required")]
        public string ItemVersion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Item Type is required")]
        public string TextbookOrSoftware { get; set; } = string.Empty;

        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher { get; set; } = string.Empty;

        public string VpatStatus { get; set; } = "Pending";

        [Required(ErrorMessage = "Class Requesting is required")]
        public string ClassRequesting { get; set; } = string.Empty;

        [Required(ErrorMessage = "Individual Requesting is required")]
        public string? IndividualRequesting { get; set; }

        public string? VpatRequestDate { get; set; }

        public string? VpatLink { get; set; }

        public string VpatOutreachDate { get; set; } = string.Empty;

        public string OutsideRiskAssessment { get; set; } = "Pending";

        public string InternalRiskAssessment { get; set; } = "Pending";

        public string? FinalApproval { get; set; } = "Pending";

        public string AdditionalNotes { get; set; } = string.Empty;

    }
}
