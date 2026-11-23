using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_5_Mockup
{
    public class DatabaseItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string TextbookOrSoftware { get; set; }
        public string Publisher { get; set; }
        public string VpatStatus { get; set; }
        public string ClassRequesting { get; set; }
        public string? IndividualRequesting { get; set; }
        public string? VpatRequestDate { get; set; }
        public string? VpatLink { get; set; }
        public string VpatOutreachDate { get; set; }
        public string OutsideRiskAssessment { get; set; }
        public string InternalRiskAssessment { get; set; }
        public string? FinalApproval { get; set; }
        public string AdditionalNotes { get; set; }

    }
}
