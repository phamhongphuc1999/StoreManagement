using StoreManagement.Model;

namespace StoreManagement.Data.Services
{
    public class BaseService
    {
        protected SQLData database;

        public BaseService()
        {
            database = SQLConnecter.Instance.SqlData;
        }
    }
}
