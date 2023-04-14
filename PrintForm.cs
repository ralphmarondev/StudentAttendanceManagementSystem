using System;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

        private void PrintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen main_screen = new MainScreen();

            main_screen.Show();
        }
    }
}
