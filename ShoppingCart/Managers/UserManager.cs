using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Engines;
using ShoppingCart.EventsArgs;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;

namespace ShoppingCart.Managers
{
    public sealed class UserManager : IManager
    {
        public event EventHandler<ProductCartListUpdatedArgs> ProductCartListUpdated;
        public event EventHandler<CurrentUserEventArgs> CurrentUserUpdated;
        public event EventHandler<UsersListUpdatedArgs> UsersListUpdated;
        public event EventHandler<CartPriceUpdatedArgs> CartPriceUpdated;

        public UserManager()
        {
            _cartProductsByItemKey = new Dictionary<ItemKey, IEnumerable<Product>>();
            _priceCartByChains = new Dictionary<Chain, double>();
            _users = UsersEngine.Users;
            _currentUser = UsersEngine.GetGeustUser();
            
            RepositoryEngine.ChainsArchive
                .ToList()
                .ForEach(chainModel => _priceCartByChains[chainModel] = 0);
        }

        private User _currentUser;
        public User CurrentUser =>_currentUser;

        public IEnumerable<User> Users => _users;
        private IEnumerable<User> _users;

        private RepositoryEngine _repositoryEngine;
        private RepositoryEngine RepositoryEngine => _repositoryEngine ?? (_repositoryEngine = new RepositoryEngine());

        private UsersEngine _userEngine;
        private UsersEngine UsersEngine => _userEngine ?? (_userEngine = new UsersEngine());

        private IDictionary<Chain, double> _priceCartByChains;

        public IEnumerable<ItemKey> ListOfProducts=> _listOfProducts ?? (_listOfProducts = RepositoryEngine.GetItemsList());
        private IEnumerable<ItemKey> _listOfProducts;

        private IDictionary<ItemKey, IEnumerable<Product>> _cartProductsByItemKey;
        public ICollection<ItemKey> ProductsInCart => _currentUser.ItemsInCart;

        private IDictionary<Chain, Tuple<IEnumerable<Product>, IEnumerable<Product>>>_cheapestAndExpentivestProductsByChains;
        public IDictionary<Chain, Tuple<IEnumerable<Product>, IEnumerable<Product>>> CheapestAndExpentivestProductsByChains
            => _cheapestAndExpentivestProductsByChains;
        
        private double GetPriceCartChain(string id)
        {
            var chain = RepositoryEngine.GetChainById(id);
            var cartPrice = _priceCartByChains[chain];
            return cartPrice;
        }
        private IEnumerable<Product> GetCheapestExpensiveProductsChain(string id , string mode)
        {
            var chain = RepositoryEngine.GetChainById(id);
            if(mode=="Cheap")
                return _cheapestAndExpentivestProductsByChains[chain].Item1;
            if (mode=="Expensive")
                return _cheapestAndExpentivestProductsByChains[chain].Item2;
            return new List<Product>();
        }
        public void AddItemToCart(ItemKey itemKey, int quantity)
        {
            UsersEngine.AddItemToCart(_currentUser,itemKey, quantity);
            OnProductCartListUpdates();
        }
        public bool RemoveItemFromCart(ItemKey itemKey)
        {
            var isRemoved =  UsersEngine.RemoveItemFromCart(_currentUser,itemKey);
            if(isRemoved)
                OnProductCartListUpdates();
            return isRemoved;
        }
        public void CalculateCart()
        {
            _priceCartByChains = RepositoryEngine.GetCartPrice(ProductsInCart);
            _cartProductsByItemKey = RepositoryEngine.GetPrudcutsCart(ProductsInCart);
            _cheapestAndExpentivestProductsByChains = RepositoryEngine.GetChipestExpentivestProductsByChains();
            
            OnCartPriceUpdated();
        }
        public void SaveShoppingCart(string file) 
        {
            UsersEngine.SaveShoppingCart(_currentUser,file);
        }
        public void LoadShoppingCart(string file)
        {
            UsersEngine.LoadShoppingCart(_currentUser,file);
            OnProductCartListUpdates();
        }

        public async void CreatExcelFileShoppingCart(string fileName)
        {
            await RepositoryEngine.CeateAndSaveExcelFileProductCartAsync(fileName, _cartProductsByItemKey);
        }
        
        public bool SignUpNewUser(string name)
        {
            var userAdded = _userEngine.AddUser(name);
            if (userAdded)
            {
                _users = _userEngine.Users;
                OnUsersListUpdated();
                return true;
            }
            return false;
        }
        public void ChooseCurrentUser(User user)
        {
            _currentUser = _userEngine.IsContainsUser(user) ? 
                _userEngine.Users.Single(x => (x.UserId == user.UserId)) : _userEngine.GetGeustUser();

            OnCurrentUserUpdated();
            OnProductCartListUpdates();
        }
        public bool RemoveUser(User user)
        {
            var isUserRemoved =  _userEngine.RemoveUser(user);
            if (isUserRemoved)
            {
                _currentUser = _userEngine.GetGeustUser();

                OnUsersListUpdated();
                OnCurrentUserUpdated();
                OnProductCartListUpdates();
                return true;
            }
            return false;
        }

        private void OnProductCartListUpdates()
        {
            var args = new ProductCartListUpdatedArgs()
            {
                ListProductsInCart = _currentUser.ItemsInCart
            };

            ProductCartListUpdated?.Invoke(this, args);
        }
        private void OnCurrentUserUpdated()
        {
            var args = new CurrentUserEventArgs
            {
                UserId = _currentUser.UserId,
                UserName = _currentUser.Name
            };

            CurrentUserUpdated?.Invoke(this, args);
        }
        private void OnUsersListUpdated()
        {
            var args = new UsersListUpdatedArgs()
            {
                UsersList = _users
            };
            UsersListUpdated?.Invoke(this, args);
        }
        private void OnCartPriceUpdated()
        {
            var args = new CartPriceUpdatedArgs()
            {
                ViktoryChipestProducts = GetCheapestExpensiveProductsChain("1", "Cheap"),
                ViktoryExpensiveProducts = GetCheapestExpensiveProductsChain("1", "Expensive"),
                ShookHaairChipestProducts = GetCheapestExpensiveProductsChain("2", "Cheap"),
                ShookHaairExpensiveProducts = GetCheapestExpensiveProductsChain("2", "Expensive"),
                MahsaneyHashookChipestProducts = GetCheapestExpensiveProductsChain("3", "Cheap"),
                MahsaneyHashookExpensiveProducts = GetCheapestExpensiveProductsChain("3", "Expensive"),

                ViktoryCartPrice = GetPriceCartChain("1"),
                ShookHaairCartPrice = GetPriceCartChain("2"),
                MahsaneyHashookCartPrice = GetPriceCartChain("3")
            };

            CartPriceUpdated?.Invoke(this,args);
        }
    }
}
