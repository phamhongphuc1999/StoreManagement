using StoreManagement.Model;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class UserService
    {
        public bool Login(string username, string password)
        {
            User user = SQLConnecter.Instance.SqlData.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (user == null) return false;
            string hashPassword = Utilities.MD5Hash(Utilities.Base64Encode(password));
            return user.Password == password;
        }
    }
}
