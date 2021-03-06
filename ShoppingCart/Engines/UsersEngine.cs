﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using ShoppingCart.Resources;

namespace ShoppingCart.Engines
{
    internal class UsersEngine : IUserEngine
    {
        private readonly string _xmlPath;
        private readonly string _fileSerializationName;

        public UsersEngine()
        {
            _xmlPath = PathsInfo.XmlPath;
            _fileSerializationName = "Users.dat";
            LoadUsers();
        }
        ~UsersEngine()
        {
            SaveUsers();
        }

        public ICollection<User> Users => _users;
        private ICollection<User> _users;

        private void SaveUsers()
        {
            var file = _xmlPath + _fileSerializationName;

            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, _users);
            }
        }
        private void LoadUsers()
        {
            var file = _xmlPath + _fileSerializationName;

            if (!File.Exists(file))
            {
                _users = new List<User>();
                return;
            }

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                _users = (ICollection<User>)formatter.Deserialize(stream);
            }
        }

        public User GetGeustUser()
        {
            return new User()
            {
                Name = "Guest",
                UserId = "0" 
            };
        }
        public bool AddUser(string name)
        {
            var isExistUser = _users.Any(x => x.Name == name);
            if (isExistUser || !name.Any())
                return false;

            _users.Add(new User()
            {
                UserId = Guid.NewGuid().ToString("N") ,
                Name = name
            });
            return true;
        }
        public bool RemoveUser(User user)
        {
            var isExistUser = _users.Contains(user);
            if (!isExistUser)
                return false;

            return _users.Remove(user);
        }
        public bool IsContainsUser(User user)
        {
            var isContainUserWithId = _users.Any(x => x.UserId == user.UserId);
            return isContainUserWithId;
        }

        public void AddItemToCart(User currentUser,ItemKey itemKey, int quantity)
        {
            if (!(quantity > 0 && quantity < int.MaxValue))
                throw new Exception($"Quantity of item must be positive and smaller than {int.MaxValue}");

            if (currentUser.ItemsInCart.All(x => x.ItemId == itemKey.ItemId) && currentUser.ItemsInCart.Any())
                throw new Exception("Item already axist in the cart");

            currentUser.ItemsInCart.Add(new ItemKey()
            {
                Quantity = quantity,
                ProductName = quantity + "*" + itemKey.ProductName,
                ItemId = itemKey.ItemId
            });
        }
        public bool RemoveItemFromCart(User currentUser , ItemKey itemKey)
        {
            return currentUser.ItemsInCart.Remove(itemKey);
        }
        public void LoadShoppingCart(User currentUser , string fileLocation)
        {
            string extension = Path.GetExtension(fileLocation);
            bool isFileNameValid = extension == ".dat";
            bool isFilePathEmpty = !fileLocation.Any();

            if (isFilePathEmpty)
                return;
            if (isFileNameValid)
            {
                using (Stream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    IFormatter formatter = new BinaryFormatter();
                    currentUser.ItemsInCart = (List<ItemKey>)formatter.Deserialize(stream);
                }
            }
            else
                throw new Exception("File path not invalid.Must be .dat");
        }
        public void SaveShoppingCart(User currentUser ,string fileLocation)
        {
            string extension = Path.GetExtension(fileLocation);
            bool isFileNameValid = extension == ".dat";
            bool isFilePathEmpty = !fileLocation.Any();

            if (isFilePathEmpty)
                return;
            if (isFileNameValid)
            {
                using (Stream stream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, currentUser.ItemsInCart);
                }
            }
            else
                throw new Exception("File path not valid.Must be .dat");

        }
    }
}
