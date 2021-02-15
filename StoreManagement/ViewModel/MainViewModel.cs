using StoreManagement.Data;
using StoreManagement.Data.Services;
using StoreManagement.Model;
using StoreManagement.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitWindowCommand { get; set; }
        public ICommand SuplierWindowCommand { get; set; }
        public ICommand CustomerWindowCommand { get; set; }
        public ICommand ObjectWindowCommand { get; set; }
        public ICommand UserWindowCommand { get; set; }
        public ICommand InputWindowCommand { get; set; }
        public ICommand OutputWindowCommand { get; set; }
        public ICommand FilterButtonCommand { get; set; }

        private ObjectService objectService;

        private ObservableCollection<InventoryObject> inventoryObjects;
        public ObservableCollection<InventoryObject> InventoryObjects
        {
            get { return inventoryObjects; }
            set
            {
                inventoryObjects = value;
                int _inputCount = 0, _outputCount = 0;
                foreach(InventoryObject item in inventoryObjects)
                {
                    _inputCount += item.Input;
                    _outputCount += item.Output;
                }
                InputCount = _inputCount;
                OutputCount = _outputCount;
                InventoryCount = InputCount - OutputCount;
                OnPropertyChanged();
            }
        }

        private int inputCount;
        public int InputCount
        {
            get { return inputCount; }
            set
            {
                inputCount = value;
                OnPropertyChanged();
            }
        }

        private int outputCount;
        public int OutputCount
        {
            get { return outputCount; }
            set
            {
                outputCount = value;
                OnPropertyChanged();
            }
        }

        private int inventoryCount;
        public int InventoryCount
        {
            get { return inventoryCount; }
            set
            {
                inventoryCount = value;
                OnPropertyChanged();
            }
        }

        private DateTime startTime;
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                OnPropertyChanged();
            }
        }

        private DateTime endTime;
        public DateTime EndTime
        {
            get { return endTime; }
            set
            {
                endTime = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            SQLConnecter.CreateConnection();
            objectService = new ObjectService();
            InventoryObjects = new ObservableCollection<InventoryObject>();

            StartTime = DateTime.Now;
            EndTime = DateTime.Now;

            InitializeLoadedWindowCommand();
            InitializeUnitWindowCommand();
            InitializeSuplierWindowCommand();
            InitializeCustomerWindowCommand();
            InitializeObjectWindowCommand();
            InitializeUserWindowCommand();
            InitializeInputWindowCommand();
            InitializeOutputWindowCommand();
            InitializeFilterButtonCommand();
        }

        private void InitializeLoadedWindowCommand()
        {
            LoadedWindowCommand = new RelayCommand<Window>(
                sender => { return true; }, sender =>
                {
                    if (sender == null) return;
                    sender.Hide();
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                    LoginViewModel loginView = loginWindow.DataContext as LoginViewModel;
                    if (loginView.IsLogin)
                    {
                        sender.Show();
                        InventoryObjects = objectService.GetInventoryObjects();
                    }
                });
        }

        private void InitializeUnitWindowCommand()
        {
            UnitWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    UnitWindow unitWindow = new UnitWindow();
                    unitWindow.ShowDialog();
                });
        }

        private void InitializeSuplierWindowCommand()
        {
            SuplierWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    SuplierWindow suplierWindow = new SuplierWindow();
                    suplierWindow.ShowDialog();
                });
        }

        private void InitializeCustomerWindowCommand()
        {
            CustomerWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    CustomerWindow customerWindow = new CustomerWindow();
                    customerWindow.ShowDialog();
                });
        }

        private void InitializeObjectWindowCommand()
        {
            ObjectWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    ObjectWindow objectWindow = new ObjectWindow();
                    objectWindow.ShowDialog();
                });
        }

        private void InitializeUserWindowCommand()
        {
            UserWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    UserWindow userWindow = new UserWindow();
                    userWindow.ShowDialog();
                });
        }

        private void InitializeInputWindowCommand()
        {
            InputWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    InputWindow inputWindow = new InputWindow();
                    inputWindow.ShowDialog();
                });
        }

        private void InitializeOutputWindowCommand()
        {
            OutputWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    OutputWindow outputWindow = new OutputWindow();
                    outputWindow.ShowDialog();
                });
        }

        private void InitializeFilterButtonCommand()
        {
            FilterButtonCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    InventoryObjects = objectService.GetInventoryObjects(StartTime, EndTime);
                });
        }
    }
}
