using Microsoft.EntityFrameworkCore;
using StoreManagement.Model;

namespace StoreManagement.Data
{
    public class SQLConnecter
    {
        public SQLData SqlData { get; private set; }

        public DbContextOptionsBuilder<SQLData> Option { get; private set; }
        private static SQLConnecter connecter;

        private SQLConnecter(string CONNECT_STRING)
        {
            Option = new DbContextOptionsBuilder<SQLData>();
            Option.UseSqlServer(CONNECT_STRING);
            SqlData = new SQLData(Option.Options);
        }

        public static SQLConnecter Instance
        {
            get
            {
                if (connecter == null) connecter = new SQLConnecter(Constant.SQL_CONNECT_STRING);
                return connecter;
            }
        }
    }
}
