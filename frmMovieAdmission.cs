namespace TAH.MovieAdmission.UI
{
    public partial class frmMovieAdmission : Form
    {
        public frmMovieAdmission()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Gets the values from the checkboxes
            bool hasParent = chkParent.Checked;
            bool hasTicket = chkTicket.Checked;
            bool isBanned = chkBanned.Checked;

            int age;

            // Validates the age input
            if (int.TryParse(txtAge.Text, out age))
            {
                // Checks the admission criteria
                if (hasTicket == true && isBanned == false)
                {
                    //Checks if the customer is 18 or older
                    if (age >= 18)
                    {
                        lblResult.Text = "Admission Approved";
                    }
                    //Checks if the customer has a parent
                    else if (hasParent == true)
                    {
                        lblResult.Text = "Admission Approved";
                    }
                    else
                    {
                        lblResult.Text = "Admission Denied";
                    }
                }
                else
                {
                    lblResult.Text = "Admission Denied";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
        }
    }
}
