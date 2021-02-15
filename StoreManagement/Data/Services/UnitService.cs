using StoreManagement.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class UnitService: BaseService
    {
        public UnitService(): base() { }

        public ObservableCollection<Unit> GetListUnit()
        {
            IEnumerable<Unit> unitList = database.Units.AsEnumerable();
            return new ObservableCollection<Unit>(unitList);
        }


    }
}
