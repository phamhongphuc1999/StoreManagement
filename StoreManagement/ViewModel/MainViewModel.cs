using StoreManagement.View;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand LoadedWindowCommand { get; set; }

        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                });
        }
    }
}
