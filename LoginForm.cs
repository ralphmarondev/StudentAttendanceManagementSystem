using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(
                @"Data Source = LAPTOP-T2HJFRJU\SQLEXPRESS;
                Initial Catalog = StudentAttendanceManagementSystem;
                Integrated Security = True"
            );
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //MainScreen main_screen = new MainScreen();

            //main_screen.Show();
            //this.Hide();

            string username, password;

            username = tb_username.Text;
            password = tb_password.Text;

            try
            {
                string querry = "SELECT * FROM UsersTable WHERE username = '" + tb_username.Text + "'AND password = '" + tb_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MainScreen main_screen = new MainScreen();

                    main_screen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_username.Clear();
                    tb_password.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Credentials!");
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void link_lbl_forgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Default Credentials are:\n\nUsername: root\nPassword: toor\n\nChange these upon logging in!", "HINT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_password.Clear();
        }
    }
}
