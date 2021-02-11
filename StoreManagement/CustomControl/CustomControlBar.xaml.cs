using StoreManagement.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomControlBar.xaml
    /// </summary>
    public partial class CustomControlBar : UserControl
    {
        public CustomControlBarViewModel customControlBarViewModel { get; set; }

        public CustomControlBar()
        {
            InitializeComponent();
            customControlBarViewModel = new CustomControlBarViewModel();
            this.DataContext = customControlBarViewModel;
        }
    }
}
