using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen main_screen = new MainScreen();

            main_screen.Show();
        }

        private void AttendanceForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
