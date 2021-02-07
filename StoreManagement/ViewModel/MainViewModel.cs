using StoreManagement.View;
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

        public MainViewModel()
        {
            InitializeLoadedWindowCommand();
            InitializeUnitWindowCommand();
            InitializeSuplierWindowCommand();
            InitializeCustomerWindowCommand();
            InitializeObjectWindowCommand();
            InitializeUserWindowCommand();
            InitializeInputWindowCommand();
            InitializeOutputWindowCommand();
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
                    if (loginView.IsLogin) sender.Show();
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
    }
}
