using System.Windows;
using System.Windows.Controls;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for FilterDetailCard.xaml
    /// </summary>
    public partial class FilterDetailCard : UserControl
    {
        private static DependencyProperty CustomTitleProperty = DependencyProperty.Register(
            "CustomTitle", typeof(string), typeof(FilterDetailCard));
        public string CustomTitle
        {
            get { return (string)GetValue(CustomTitleProperty); }
            set
            {
                SetValue(CustomTitleProperty, value);
            }
        }

        private static DependencyProperty InfoProperty = DependencyProperty.Register(
            "Info", typeof(string), typeof(FilterDetailCard));
        public string Info
        {
            get { return (string)GetValue(InfoProperty); }
            set
            {
                SetValue(InfoProperty, value);
            }
        }

        public FilterDetailCard()
        {
            InitializeComponent();
            CustomTitle = "FilterDetailCard";
            Info = "customUserControl";
        }
    }
}
