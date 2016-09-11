using System;
using ShoppingCart.EventsArgs;
using ShoppingCart.Models;

namespace ShoppingCart.Interfaces
{
    public interface IManager
    {
        event EventHandler<ProductCartListUpdatedArgs> ProductCartListUpdated;
        event EventHandler<CurrentUserEventArgs> CurrentUserUpdated;
        event EventHandler<UsersListUpdatedArgs> UsersListUpdated;
        event EventHandler<CartPriceUpdatedArgs> CartPriceUpdated;

        void AddItemToCart(ItemKey itemKey, int quantity);
        bool RemoveItemFromCart(ItemKey itemKey);
        void CalculateCart();
        void SaveShoppingCart(string file);
        void LoadShoppingCart(string file);
        void CreatExcelFileShoppingCart(string fileName); 
        bool SignUpNewUser(string name);
        void ChooseCurrentUser(User user);
        bool RemoveUser(User user);
    }
}
