using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingCart.Managers;
using ShoppingCart.Models;

namespace UIShoppingCart
{
    public partial class RemoveUserForm : Form
    {
        private UserManager _application;

        public RemoveUserForm()
        {
            InitializeComponent();
        }

        public RemoveUserForm(UserManager _application)
        {
            this._application = _application;
            InitializeComponent();

            UsersBox.DataSource = this._application.Users;
            UsersBox.DisplayMember = "Name";
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            var selectedUser = UsersBox.SelectedItem as User;
            if (selectedUser != null)
            {
                if (_application.RemoveUser(selectedUser)) 
                    this.Close();
                else
                    MessageBox.Show("User can't removed.Try again!");
            }
        }
    }
}
