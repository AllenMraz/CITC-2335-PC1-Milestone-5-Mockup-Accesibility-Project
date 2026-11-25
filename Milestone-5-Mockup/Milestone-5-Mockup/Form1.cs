namespace Milestone_5_Mockup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {

        }

        // I didn't finish this, but this is the displaycurrentitems method that will happen
        // upon initialization.

        // It would also need to run every time the search bar is updated, but I haven't
        // actually added that functionality. I could make it work with that, but it would take time.
        public void displayCurrentItems()
        {
            var accessibleItems = ObjectListFromFilePath.GetObjects();

            var results = from i in accessibleItems
                          orderby i.ItemId
                          select new
                          {
                              i.ItemId,
                              i.ItemName,

                          };

            string firstName = string.Empty;

            // this is a test for later

            lbx_itemDisplay.Items.Add("First".PadRight(15) +
                                    "2nd".PadRight(10) +
                                    "3rd".PadRight(15) +
                                    "4th".PadRight(15) +
                                    "5th");

            foreach (var t in results)
            {

                // commented out because this hasn't been updated for the project yet.

                //lbx_itemDisplay.Items.Add(t.Name.PadRight(15) +
                //                        t.ProductCode.PadRight(10) +
                //                        t.DateOpened.PadRight(15) +
                //                        t.DateClosed.PadRight(15) +
                //                        t.Title);
                //firstName = t.Name;

            }
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
