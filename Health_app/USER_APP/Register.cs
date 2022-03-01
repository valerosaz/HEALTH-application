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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e) // get rid of focusing on text boxes
        {
            this.ActiveControl = label1;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ss = new login();
            ss.Show();
        }


        // First Name
        private void TextBoxFirstname_Enter(object sender, EventArgs e)
        {
            String firstname = textBoxFirstname.Text;
            if(firstname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }
        private void TextBoxFirstname_Leave(object sender, EventArgs e)
        {
            String firstname = textBoxFirstname.Text;
            if (firstname.ToLower().Trim().Equals("first name") || firstname.Equals(""))
            {
                textBoxFirstname.Text = "first name";
                textBoxFirstname.ForeColor = Color.Gray;
            }

        }

        
        // Last Name
        private void TextBoxLastname_Enter(object sender, EventArgs e)
        {
            String lastname = textBoxLastname.Text;
            if (lastname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void TextBoxLastname_Leave(object sender, EventArgs e)
        {
            String lastname = textBoxLastname.Text;
            if (lastname.ToLower().Trim().Equals("last name") || lastname.Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }


        // Email
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email") || email.Equals(""))
            {
                textBoxEmail.Text = "email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }


        // User ID
        private void TextBoxUserId_Enter(object sender, EventArgs e)
        {
            String userid = textBoxUserId.Text;
            if (userid.ToLower().Trim().Equals("user id"))
            {
                textBoxUserId.Text = "";
                textBoxUserId.ForeColor = Color.Black;
            }
        }

        private void TextBoxUserId_Leave(object sender, EventArgs e)
        {
            String userid = textBoxUserId.Text;
            if (userid.ToLower().Trim().Equals("user id") || userid.Equals(""))
            {
                textBoxUserId.Text = "user id";
                textBoxUserId.ForeColor = Color.Gray;
            }
        }


        // User Birthday
        private void TextBoxUserBirthday_Enter(object sender, EventArgs e)
        {
            String userbirthday = textBoxUserBirthday.Text;
            if (userbirthday.ToLower().Trim().Equals("user birthday"))
            {
                textBoxUserBirthday.Text = "";
                textBoxUserBirthday.ForeColor = Color.Black;
            }
        }

        private void TextBoxUserBirthday_Leave(object sender, EventArgs e)
        {
            String userbirthday = textBoxUserBirthday.Text;
            if (userbirthday.ToLower().Trim().Equals("user birthday") || userbirthday.Equals(""))
            {
                textBoxUserBirthday.Text = "user birthday";
                textBoxUserBirthday.ForeColor = Color.Gray;
            }
        }


        // User Address
        private void TextBoxUserAddress_Enter(object sender, EventArgs e)
        {
            String useraddress = textBoxUserAddress.Text;
            if (useraddress.ToLower().Trim().Equals("user address"))
            {
                textBoxUserAddress.Text = "";
                textBoxUserAddress.ForeColor = Color.Black;
            }
        }

        private void TextBoxUserAddress_Leave(object sender, EventArgs e)
        {
            String useraddress = textBoxUserAddress.Text;
            if (useraddress.ToLower().Trim().Equals("user address") || useraddress.Equals(""))
            {
                textBoxUserAddress.Text = "user address";
                textBoxUserAddress.ForeColor = Color.Gray;
            }
        }


        // User Phone Number
        private void TextBoxUserPhoneNumber_Enter(object sender, EventArgs e)
        {
            String userphonenumber = textBoxUserPhoneNumber.Text;
            if (userphonenumber.ToLower().Trim().Equals("user phone number"))
            {
                textBoxUserPhoneNumber.Text = "";
                textBoxUserPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void TextBoxUserPhoneNumber_Leave(object sender, EventArgs e)
        {
            String userphonenumber = textBoxUserPhoneNumber.Text;
            if (userphonenumber.ToLower().Trim().Equals("user phone number") || userphonenumber.Equals(""))
            {
                textBoxUserPhoneNumber.Text = "user phone number";
                textBoxUserPhoneNumber.ForeColor = Color.Gray;
            }
        }


        // User Name
        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("user name"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("user name") || username.Equals(""))
            {
                textBoxUsername.Text = "user name";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }


        // Password
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }


        // Confirm Password
        private void TextBoxPasswordconfirm_Enter(object sender, EventArgs e)
        {
            String passwordConfirm = textBoxPasswordconfirm.Text;
            if (passwordConfirm.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordconfirm.Text = "";
                textBoxPasswordconfirm.UseSystemPasswordChar = true;
                textBoxPasswordconfirm.ForeColor = Color.Black;
            }
        }

        private void TextBoxPasswordconfirm_Leave(object sender, EventArgs e)
        {
            String passwordConfirm = textBoxPasswordconfirm.Text;
            if (passwordConfirm.ToLower().Trim().Equals("confirm password") || 
                passwordConfirm.ToLower().Trim().Equals("password") ||
                passwordConfirm.Trim().Equals(""))
            {
                textBoxPasswordconfirm.Text = "confirm password";
                textBoxPasswordconfirm.UseSystemPasswordChar = false;
                textBoxPasswordconfirm.ForeColor = Color.Gray;
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            // Add new user for the database
            MySqlCommand command = new MySqlCommand("INSERT INTO user_information (user_firstname, user_lastname, user_email, user_id, user_birthday, user_address, user_phonenumber, user_user, user_pass) VALUES (@user_firstname, @user_lastname, @user_email, @user_id, @user_birthday, @user_address, @user_phonenumber, @user_user, @user_pass)", db.GetConnection());
            command.Parameters.Add("@user_firstname", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@user_lastname", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@user_email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = textBoxUserId.Text;
            command.Parameters.Add("@user_birthday", MySqlDbType.VarChar).Value = textBoxUserBirthday.Text;
            command.Parameters.Add("@user_address", MySqlDbType.VarChar).Value = textBoxUserAddress.Text;
            command.Parameters.Add("@user_phonenumber", MySqlDbType.VarChar).Value = textBoxUserPhoneNumber.Text;
            command.Parameters.Add("@user_user", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@user_pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            // Opening the new connection
            db.initConnection();


            // Check if the text boxes that still have the default values
            if (!textBoxCheck())
            {
                // Password confirm check
                if (textBoxPassword.Text.Equals(textBoxPasswordconfirm.Text))
                {
                    // Check if the username was the same as the one that used before
                    if (userNameCheck())
                    {
                        MessageBox.Show("This user name was used, choose another one!","Invalid username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Executing queries
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("ACCOUNT CREATED SUCCESS!!!","YOUR ACCOUNT HAVE BEEN CREATED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("WRONG PASSWORD CONFIRMATION!","INVALID PASSWORD", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("PLEASE FILL IN YOUR INFORMATIONS FIRST","EMPTY INPUT DATA!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

          

            // Closing the connection
            db.stopConnection();
        }
        // Function to check if the username is already exist
        public Boolean userNameCheck()
        {
            Database db = new Database();
            String username = textBoxUsername.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT user_user FROM healthbot.user_information", db.GetConnection());
            command.Parameters.Add("user_user", MySqlDbType.VarChar).Value = username;
            
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // If the text boxes contains the default values
        public Boolean textBoxCheck()
        {
            String firstname = textBoxFirstname.Text;
            String lastname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String id = textBoxUserId.Text;
            String birthday = textBoxUserBirthday.Text;
            String address = textBoxUserAddress.Text;
            String phone = textBoxUserPhoneNumber.Text;
            String usname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if (firstname.Equals("first name") || lastname.Equals("last name") || email.Equals("email") || id.Equals("user id") || birthday.Equals("user birthday") || address.Equals("user address") || phone.Equals("user phone number") || usname.Equals("user name") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonCancel_Leave(object sender, EventArgs e)
        { 
            
        }


        
    }
}
