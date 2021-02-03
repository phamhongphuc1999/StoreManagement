using StoreManagement.ViewModel;
using System.Windows.Controls;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomControlBar.xaml
    /// </summary>
    public partial class CustomControlBar : UserControl
    {
        public ControlBarViewModel controlBarViewModel { get; set; }

        public CustomControlBar()
        {
            InitializeComponent();
            this.DataContext = controlBarViewModel = new ControlBarViewModel();
        }
    }
}
