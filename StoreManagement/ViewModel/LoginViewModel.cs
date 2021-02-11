using StoreManagement.Data.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class LoginViewModel : BaseViewModel
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
                    if (sender == null)
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if (username == "" || password == "")
                    {
                        MessageBox.Show("Yêu cầu nhập đầy đủ các trường", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    IsLogin = userService.Login(Username, Password);
                    if (!IsLogin)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    sender.Close();
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
