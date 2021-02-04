using StoreManagement.View;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitWindowCommand { get; set; }
        public ICommand SuplierWindowCommand { get; set; }

        public MainViewModel()
        {
            InitializeLoadedWindowCommand();
            InitializeUnitWindowCommand();
            InitializeSuplierWindowCommand();
        }

        private void InitializeLoadedWindowCommand()
        {
            LoadedWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                });
        }

        private void InitializeUnitWindowCommand()
        {
            UnitWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender => {
                    UnitWindow unitWindow = new UnitWindow();
                    unitWindow.ShowDialog();
                });
        }

        private void InitializeSuplierWindowCommand()
        {
            SuplierWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender => {
                    SuplierWindow suplierWindow = new SuplierWindow();
                    suplierWindow.ShowDialog();
                });
        }
    }
}
