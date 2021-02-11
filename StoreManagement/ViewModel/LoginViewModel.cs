using StoreManagement.Data.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        private UserService userService;

        public bool IsLogin { get; private set; }
        public ICommand LoginButtonCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        private string username, password;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            userService = new UserService();

            IsLogin = false;
            InitializeLoginButtonCommand();
            InitializePasswordChangedCommand();
        }

        private void InitializeLoginButtonCommand()
        {
            LoginButtonCommand = new RelayCommand<Window>(
                sender => { return true; }, sender =>
                {
                    if (sender == null) return;
                    if (username == "" || password == "") return;
                    IsLogin = userService.Login(Username, Password);
                    if (IsLogin) sender.Close();
                });
        }

        private void InitializePasswordChangedCommand()
        {
            PasswordChangedCommand = new RelayCommand<PasswordBox>(
                sender => { return true; }, sender =>
                {
                    Password = sender.Password;
                });
        }
    }
}
