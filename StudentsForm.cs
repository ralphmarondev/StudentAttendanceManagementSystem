using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen main_screen = new MainScreen();

            main_screen.Show();
        }
    }
}
