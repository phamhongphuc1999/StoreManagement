using System.Windows;

namespace StoreManagement.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public MainViewModel()
        {
            MessageBox.Show("Đã vào trong MainViewModel -> DataContext của mainwindow.xaml");
        }
    }
}
