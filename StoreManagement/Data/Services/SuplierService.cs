using StoreManagement.Model;
using System.Collections.Generic;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class SuplierService: BaseService
    {
        public SuplierService(): base() { }

        public List<Suplier> GetListSupliers()
        {
            return database.Supliers.ToList();
        }
    }
}
