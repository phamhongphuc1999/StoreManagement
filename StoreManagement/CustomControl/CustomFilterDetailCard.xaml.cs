using System.Windows;
using System.Windows.Controls;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomFilterDetailCard.xaml
    /// </summary>
    public partial class CustomFilterDetailCard : UserControl
    {
        private static DependencyProperty CustomTitleProperty = DependencyProperty.Register(
            "CustomTitle", typeof(string), typeof(CustomFilterDetailCard));
        public string CustomTitle
        {
            get { return (string)GetValue(CustomTitleProperty); }
            set
            {
                SetValue(CustomTitleProperty, value);
            }
        }

        private static DependencyProperty InfoProperty = DependencyProperty.Register(
            "Info", typeof(string), typeof(CustomFilterDetailCard));
        public string Info
        {
            get { return (string)GetValue(InfoProperty); }
            set
            {
                SetValue(InfoProperty, value);
            }
        }

        public CustomFilterDetailCard()
        {
            InitializeComponent();
            CustomTitle = "CustomFilterDetailCard";
            Info = "customUserControl";
        }
    }
}
