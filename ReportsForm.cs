using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen main_screen = new MainScreen();

            main_screen.Show();
        }
    }
}
