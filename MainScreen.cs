using System;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm();
            login_form.Show();
            this.Close();
        }

        private void btn_pack_Click(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm();

            login_form.Show();
            this.Hide();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UsersForm user_form = new UsersForm();

            user_form.Show();
            Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            HelpForm help_form = new HelpForm();

            help_form.Show();
            Hide();
        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            ClassesForm classes_form = new ClassesForm();

            classes_form.Show();
            Hide();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ReportsForm reports_form = new ReportsForm();

            reports_form.Show();
            Hide();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintForm print_form = new PrintForm();

            print_form.Show();
            Hide();
        }
    }
}
