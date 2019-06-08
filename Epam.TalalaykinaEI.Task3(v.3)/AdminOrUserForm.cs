using BL;
using Epam.TalalaykinaEI.Task3_v._3_.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    public partial class AdminOrUserForm : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();

        public AdminOrUserForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == ""))
            {
                MessageBox.Show("Please, enter your login and/or password!");
            }

            else if ((int.TryParse(loginTextBox.Text, out int userID)) && (passwordTextBox.Text == "user")) 
            {
                if (owner_ListLogic.IsOwnerExists(userID) == -1)
                {
                    MessageBox.Show("Username does not exist!");
                }
                else
                {
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                    Form userForm = new UserForm(userID);
                    userForm.ShowDialog();
                }
                
            }
            else if ((loginTextBox.Text == "ad") && (passwordTextBox.Text == "ad"))
            {
                loginTextBox.Clear();
                passwordTextBox.Clear();
                Form adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong login and/or password!");
            }


        }

        private void AdminOrUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
