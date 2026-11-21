using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_5_Mockup
{
    internal class DatabaseItem
    {
        internal string ItemName { get; set; }
        internal string TextbookOrSoftware { get; set; }
        internal string Publisher { get; set; }
        internal string VpatStatus { get; set; }
        internal string ClassRequesting { get; set; }
        internal string? IndividualRequesting { get; set; }
        internal string? VpatRequestDate { get; set; }
        internal string? VpatLink { get; set; }
        internal string VpatOutreachDate { get; set; }
        internal string OutsideRiskAssessment { get; set; }
        internal string InternalRiskAssessment { get; set; }
        internal string? FinalApproval { get; set; }
        internal string AdditionalNotes { get; set; }

    }
}
