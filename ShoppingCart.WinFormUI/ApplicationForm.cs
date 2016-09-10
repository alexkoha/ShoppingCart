using System;
using System.Windows.Forms;
using ShoppingCart.Managers;
using ShoppingCart.Models;
using UIShoppingCart;
using ShoppingCart.EventsArgs;

namespace ShoppingCart.WinFormUI
{
    public partial class ApplicationForm : Form
    {
        private readonly UserManager _application;

        public ApplicationForm()
        {
            _application = new UserManager();
            
            InitializeComponent();
            Initialize();

            _application.ProductCartListUpdated += ApplicationOnProductCartListUpdated;
            _application.UsersListUpdated += ApplicationOnUsersListUpdated;
            _application.CartPriceUpdated += ApplicationOnCartPriceUpdated;
            _application.CurrentUserUpdated += ApplicationOnCurrentUserUpdated;
        }

        private void Initialize()
        {
            var listOfProducts = _application.ListOfProducts;
            ProductBox.DataSource = listOfProducts;
            ProductBox.DisplayMember = "ProductName";
            UsersComboBox.DataSource = _application.Users;
            UsersComboBox.DisplayMember = "Name";
            UserNameText.Text = _application.CurrentUser.Name;

            QuantityBox.Text = "1";

            ViktoryCartPriceLabal.Text = "0";
            ShookHaiirCartPriceLabal.Text = "0";
            MahsaneiCartPeiceLabal.Text = "0";


        }

        private void ApplicationOnCartPriceUpdated(object sender, CartPriceUpdatedArgs args)
        {
            CheapestViktoryListBox.DisplayMember = "ProductName";
            CheapestViktoryListBox.DataSource = args.ViktoryChipestProducts;

            ExpensiveViktoryListBox.DisplayMember = "ProductName";
            ExpensiveViktoryListBox.DataSource = args.ViktoryExpensiveProducts;

            CheapestMahsaneiListBox.DisplayMember = "ProductName";
            CheapestMahsaneiListBox.DataSource = args.MahsaneyHashookChipestProducts;

            ExpensiveMahsaneiListBox.DisplayMember = "ProductName";
            ExpensiveMahsaneiListBox.DataSource = args.MahsaneyHashookExpensiveProducts;

            CheapestShookListBox.DisplayMember = "ProductName";
            CheapestShookListBox.DataSource = args.ShookHaairChipestProducts;

            ExpensiveShookListBox.DisplayMember = "ProductName";
            ExpensiveShookListBox.DataSource = args.ShookHaairExpensiveProducts;



            ViktoryCartPriceLabal.Text = args.ViktoryCartPrice.ToString();
            ShookHaiirCartPriceLabal.Text = args.ShookHaairCartPrice.ToString();
            MahsaneiCartPeiceLabal.Text = args.MahsaneyHashookCartPrice.ToString();
        }
        private void ApplicationOnUsersListUpdated(object sender, UsersListUpdatedArgs args)
        {
            UsersComboBox.DataSource = null;
            UsersComboBox.DataSource = args.UsersList;
            UsersComboBox.DisplayMember = "Name";
        }
        private void ApplicationOnProductCartListUpdated(object sender, ProductCartListUpdatedArgs args)
        {
            ShoppingCartBox.DataSource = null;
            ShoppingCartBox.DataSource = args.ListProductsInCart;
            ShoppingCartBox.DisplayMember = "ProductName";
        }
        private void ApplicationOnCurrentUserUpdated(object sender, CurrentUserEventArgs eventArgs)
        {
            UserNameText.Text = eventArgs.UserName;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var selectedItem = ProductBox.SelectedItem;
            var quantity = 0;
            if (int.TryParse(QuantityBox.Text, out quantity) && quantity > 0)
            {
                if (!ShoppingCartBox.Items.Contains(selectedItem))
                {
                    _application.AddItemToCart((ItemKey)selectedItem, quantity);
                }
                else
                {
                    MessageBox.Show("Item already in the cart");
                }
            }   
            else
            {
                MessageBox.Show("You must enter quantity and positive number");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _application.RemoveItemFromCart((ItemKey)ShoppingCartBox.SelectedItem);
        }

        private void CalculatButton_Click(object sender, EventArgs e)
        {
            _application.CalculateCart();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Date File|*.dat",
                Title = "Save Shopping Cart"
            };
            saveFileDialog1.ShowDialog();
            var fileName = saveFileDialog1.FileName;

            _application.SaveShoppingCart(fileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Date File|*.dat",
                Title = "Open file Shopping Cart"
            };
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.SafeFileName;

            _application.LoadShoppingCart(fileName);

        }

        private void excelDataButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Date Data|*.xls",
                Title = "Save Shopping Cart"
            };
            saveFileDialog1.ShowDialog();
            var fileName = saveFileDialog1.FileName;

            _application.CreatExcelFileShoppingCart(fileName);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By AlexK");
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserForm newUser = new NewUserForm(_application);
            newUser.Show();
        }

        private void UsersComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _application.ChooseCurrentUser((User)UsersComboBox.SelectedItem);
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm(_application);
            removeUserForm.Show();
        }


        private void ProductBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedItem = ProductBox.SelectedItem;
            var item = selectedItem as ItemKey;
            
            PictureProduct.ImageLocation = item.ImageFilePath;
            ProductNameLabal.Text = item.ProductName;
            UnitsLabal.Text = item.UnitQty;

           
        }

        private void ChipestViktoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = CheapestViktoryListBox.SelectedItem as Product;
            if(selected!=null)
                ChipestViktoryToolTip.SetToolTip(CheapestViktoryListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");
        }

        private void ExpensiveViktoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ExpensiveViktoryListBox.SelectedItem as Product;
            if (selected != null)
                ExpensiveViktoryToolTip.SetToolTip(ExpensiveViktoryListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");
        }

        private void ChipestMahsaneiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = CheapestMahsaneiListBox.SelectedItem as Product;
            if (selected != null)
                ChipestMahsaneiToolTop.SetToolTip(CheapestMahsaneiListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");
        }

        private void ExpensiveMahsaneiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ExpensiveMahsaneiListBox.SelectedItem as Product;
            if (selected != null)
                ExpensiveMahsaneiToolTip.SetToolTip(ExpensiveMahsaneiListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");
        }


        private void ChipestShookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = CheapestShookListBox.SelectedItem as Product;
            if (selected != null)
                ChipestShookListToolTip.SetToolTip(CheapestShookListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");

        }

        private void ExpensiveShookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ExpensiveShookListBox.SelectedItem as Product;
            if (selected != null)
                ExpensiveShookToolTip.SetToolTip(ExpensiveShookListBox, selected.ProductName + " " + selected.ItemPrice + " שח ");

        }


    }

}
