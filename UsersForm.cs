using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen main_screen = new MainScreen();

            main_screen.Show();
        }

        private void UsersForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
