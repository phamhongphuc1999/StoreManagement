using StoreManagement.Data.Services;
using StoreManagement.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class UnitViewModel : BaseViewModel
    {
        private UnitService unitService;
        public ICommand AddUnitCommand { get; set; }
        public ICommand EditUnitCommand { get; set; }
        public ICommand DeleteUnitCommand { get; set; }

        private List<Unit> unitList;
        public List<Unit> UnitList
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
                if (selectedUnitItem != null) DisplayUnitName = selectedUnitItem.DisplayName;
                OnPropertyChanged();
            }
        }

        public UnitViewModel()
        {
            unitService = new UnitService();
            DisplayUnitName = "";

            UnitList = unitService.GetListUnit();

            InitializeAddUnitCommand();
            InitializeEditUnitCommand();
            InitializeDeleteUnitCommand();
        }

        private void InitializeAddUnitCommand()
        {
            AddUnitCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    if (!string.IsNullOrEmpty(DisplayUnitName))
                    {
                        bool result = unitService.AddNewUnit(DisplayUnitName);
                        if (!result)
                        {
                            MessageBox.Show("Tên đơn vị đo đã tồn tại hoặc có lỗi khi thêm đơn vị đo");
                            return;
                        }
                        UnitList = unitService.GetListUnit();
                        DisplayUnitName = "";
                    }
                });
        }

        private void InitializeEditUnitCommand()
        {
            EditUnitCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    if (string.IsNullOrEmpty(DisplayUnitName) || SelectedUnitItem == null) return;
                    unitService.EditUnit(SelectedUnitItem.DisplayName, DisplayUnitName);
                    UnitList = unitService.GetListUnit();
                });
        }

        private void InitializeDeleteUnitCommand()
        {
            DeleteUnitCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    if (!string.IsNullOrEmpty(DisplayUnitName))
                    {
                        unitService.DeleteUnit(DisplayUnitName);
                        UnitList = unitService.GetListUnit();
                    }
                });
        }
    }
}
