using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_app
{
    public partial class login : Form
    {
        /*
         * Download and add mysql connector
         * Create a connection with mysql database
         * Open xampp and start mysql & apache
         */

        public login()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT user_user , user_pass FROM healthbot.user_information WHERE user_user = '" + this.textBoxUsername.Text + "' AND user_pass = '" + this.textBoxPassword.Text + "' ;", db.GetConnection());
            command.Parameters.Add("user_user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("user_pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("LOGINED!");
                this.Hide();
                Main mainInterface = new Main();
                mainInterface.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("ENTER YOUR USERNAME TO LOGIN","NO USERNAME!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(username.Trim().Equals(""))
                {
                    MessageBox.Show("LACK OF PASSWORD TO LOGIN", "PASSWORD REQUIRED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("PASSWORD OR USERNAME IS NOT CORRECT!", "INVALID USERNAME OR PASSWORD!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
            ss.Show();
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
