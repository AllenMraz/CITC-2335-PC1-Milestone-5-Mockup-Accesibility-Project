using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_5_Mockup
{
    internal class ObjectListFromFilePath
    {

        static string Path = "sample"; // This needs to be changed to be the path to the list file,
        // since we're not doing a database though I'm assuming we're doing just a text file to
        // represent the database.
        
        public static List<DatabaseItem> GetIncidents()
        {

            using FileStream stream = new(Path, FileMode.Open, FileAccess.Read);
            using StreamReader textIn = new(stream);

            List<DatabaseItem> DatabaseItems = new();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? string.Empty;
                string[] columns = row.Split('|');

                DatabaseItem item = new()
                {
                    // I'm assuming the database file will be delimited by pipes | in the same
                    // order as listed in the database item class.

                    ItemName = columns[0],
                    TextbookOrSoftware = columns[1],
                    Publisher = columns[2],
                    VpatStatus = columns[3],
                    ClassRequesting = columns[4],
                    IndividualRequesting = columns[5],
                    VpatRequestDate = columns[6],
                    VpatLink = columns[7],
                    VpatOutreachDate = columns[8],
                    OutsideRiskAssessment = columns[9],
                    InternalRiskAssessment = columns[10],
                    FinalApproval = columns[11],
                    AdditionalNotes = columns[12]
                };

                DatabaseItems.Add(item);

            }


            return DatabaseItems;
        }
    }
}
