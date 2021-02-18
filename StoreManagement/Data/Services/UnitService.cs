using StoreManagement.Model;
using System.Collections.Generic;
using System.Linq;

namespace StoreManagement.Data.Services
{
    public class UnitService: BaseService
    {
        public UnitService(): base() { }

        public List<Unit> GetListUnit()
        {
            List<Unit> unitList = database.Units.ToList();
            return unitList;
        }

        public bool AddNewUnit(string unitDisplayName)
        {
            Unit unit = database.Units.FirstOrDefault(x => x.DisplayName == unitDisplayName);
            if (unit != null) return false;
            Unit newUnit = new Unit { DisplayName = unitDisplayName };
            database.Units.Add(newUnit);
            database.SaveChanges();
            return true;
        }

        public Unit EditUnit(int unitId, string newName)
        {
            Unit unit = database.Units.Find(unitId);
            if (unit == null) return null;
            unit.DisplayName = newName;
            database.SaveChanges();
            return unit;
        }

        public Unit EditUnit(string oldName, string newName)
        {
            Unit unit = database.Units.FirstOrDefault(x => x.DisplayName == oldName);
            if (unit == null) return null;
            unit.DisplayName = newName;
            database.SaveChanges();
            return unit;
        }

        public Unit DeleteUnit(int unitId)
        {
            Unit unit = database.Units.Find(unitId);
            if (unit == null) return null;
            database.Units.Remove(unit);
            return unit;
        }

        public Unit DeleteUnit(string unitName)
        {
            Unit unit = database.Units.FirstOrDefault(x => x.DisplayName == unitName);
            if (unit == null) return null;
            database.Units.Remove(unit);
            database.SaveChanges();
            return unit;
        }
    }
}
