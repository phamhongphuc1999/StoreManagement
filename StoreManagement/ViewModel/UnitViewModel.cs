using StoreManagement.Data.Services;
using StoreManagement.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class UnitViewModel: BaseViewModel
    {
        private UnitService unitService;
        public ICommand AddUnitCommand { get; set; }
        public ICommand EditUnitCommand { get; set; }
        public ICommand DeleteUnitCommand { get; set; }

        private ObservableCollection<Unit> unitList;
        public ObservableCollection<Unit> UnitList
        {
            get { return unitList; }
            set
            {
                unitList = value;
                OnPropertyChanged();
            }
        }

        private string displayUnitName;
        public string DisplayUnitName
        {
            get { return displayUnitName; }
            set
            {
                displayUnitName = value;
                OnPropertyChanged();
            }
        }

        private Unit selectedUnitItem;
        public Unit SelectedUnitItem
        {
            get { return selectedUnitItem; }
            set
            {
                selectedUnitItem = value;
                if(selectedUnitItem != null) displayUnitName = selectedUnitItem.DisplayName;
                OnPropertyChanged();
            }
        }

        public UnitViewModel()
        {
            unitService = new UnitService();
            DisplayUnitName = "";

            UnitList = unitService.GetListUnit();
        }
    }
}
