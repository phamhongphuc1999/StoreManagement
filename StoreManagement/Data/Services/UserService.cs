﻿using StoreManagement.Model;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class UserService
    {
        private SQLData database;

        public UserService()
        {
            database = SQLConnecter.Instance.SqlData;
        }

        public bool Login(string username, string password)
        {
            User user = database.Users.Where(x => x.Username == username).FirstOrDefault();
            if (user == null) return false;
            string hashPassword = Utilities.MD5Hash(Utilities.Base64Encode(password));
            return user.Password.Equals(hashPassword);
        }
    }
}
