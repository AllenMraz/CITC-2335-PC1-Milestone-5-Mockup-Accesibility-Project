using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_5_Mockup
{
    internal class DatabaseItem
    {
        private string ItemName { get; set; }
        private string TextbookOrSoftware { get; set; }
        private string Publisher { get; set; }
        private string VpatStatus { get; set; }
        private string ClassRequesting { get; set; }
        private string? IndividualRequesting { get; set; }
        private string? VpatRequestDate { get; set; }
        private string? VpatLink { get; set; }
        private string VpatOutreachDate { get; set; }
        private string OutsideRiskAssessment { get; set; }
        private string InternalRiskAssessment { get; set; }
        private string? FinalApproval { get; set; }
        private string AdditionalNotes { get; set; }

    }
}
