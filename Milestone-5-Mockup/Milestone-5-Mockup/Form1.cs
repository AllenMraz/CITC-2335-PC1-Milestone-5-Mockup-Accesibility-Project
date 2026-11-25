namespace Milestone_5_Mockup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayCurrentItems();
        }

        // I moved the list outside of the
        List<DatabaseItem> accessibleItems = ObjectListFromFilePath.GetObjects();



        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void displayCurrentItems()
        {
            

            var results = from i in accessibleItems
                          orderby i.ItemId
                          select new
                          {
                              
                              i.ItemName,
                              i.TextbookOrSoftware,
                              i.ItemVersion,
                              i.VpatStatus,
                              i.FinalApproval

                          };

            string firstName = string.Empty;

            // this is a test for later

            lbx_itemDisplay.Items.Add("Item Name".PadRight(20) +
                                    "Textbook/Software".PadRight(20) +
                                    "Version Num".PadRight(5) +
                                    "VPAT/WCAG".PadRight(15) +
                                    "Approval");

            foreach (var t in results)
            {

                // commented out because this hasn't been updated for the project yet.

                lbx_itemDisplay.Items.Add(Fit(t.ItemName, 20) +
                                            Fit(t.TextbookOrSoftware, 20) +
                                            Fit(t.ItemVersion, 5) +
                                            Fit(t.VpatStatus, 15) +
                                            t.FinalApproval);


            }
        }

        private static string Fit(string text, int width)
        {
            text = text ?? "";
            return text.Length > width
                ? text.Substring(0, width)
                : text.PadRight(width);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
