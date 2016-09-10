using System;
using System.Windows.Forms;
using ShoppingCart.Managers;

namespace ShoppingCart.WinFormUI
{
    public partial class NewUserForm : Form
    {
        private readonly UserManager _application;

        public NewUserForm()
        {
            InitializeComponent();
        }

        public NewUserForm(UserManager _application)
        {
            InitializeComponent();
            this._application = _application;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var isSignedUpUser = _application.SignUpNewUser(UserNameBox.Text);
            if (isSignedUpUser)
                this.Close();
            else
                MessageBox.Show("User Does not signed up.Try change the name");
        }
        
    }
}
