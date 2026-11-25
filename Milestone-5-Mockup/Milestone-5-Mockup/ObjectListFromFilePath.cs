using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_5_Mockup
{
    internal class ObjectListFromFilePath
    {

        static string Path = "..\\..\\..\\..\\sample_items.txt"; 

        //I made a sample filepath for this. This is just so we can start from the ground running.
        
        public static List<DatabaseItem> GetObjects()
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


                    ItemId = int.Parse(columns[0]),
                    ItemName = columns[1],
                    TextbookOrSoftware = columns[2],
                    Publisher = columns[3],
                    VpatStatus = columns[4],
                    ClassRequesting = columns[5],
                    IndividualRequesting = columns[6],
                    VpatRequestDate = columns[7],
                    VpatLink = columns[8],
                    VpatOutreachDate = columns[9],
                    OutsideRiskAssessment = columns[10],
                    InternalRiskAssessment = columns[11],
                    FinalApproval = columns[12],
                    AdditionalNotes = columns[13],
                    ItemVersion = columns[14],
                };

                DatabaseItems.Add(item);

            }


            return DatabaseItems;
        }
    }
}
