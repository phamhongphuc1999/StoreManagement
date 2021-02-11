using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomButton1.xaml
    /// </summary>
    public partial class CustomButton1 : UserControl
    {
        private static DependencyProperty CustomTitleProperty = DependencyProperty.Register(
            "CustomTitle", typeof(string), typeof(CustomButton1));
        public string CustomTitle
        {
            get { return (string)GetValue(CustomTitleProperty); }
            set
            {
                SetValue(CustomTitleProperty, value);
            }
        }

        private static DependencyProperty CustomIconProperty = DependencyProperty.Register(
            "CustomIcon", typeof(string), typeof(CustomButton1));
        public string CustomIcon
        {
            get { return (string)GetValue(CustomIconProperty); }
            set
            {
                SetValue(CustomIconProperty, value);
            }
        }

        public static DependencyProperty CustomButtonCommandProperty = DependencyProperty.Register(
            "CustomButtonCommand", typeof(ICommand), typeof(CustomButton1));

        public ICommand CustomButtonCommand
        {
            get { return (ICommand)GetValue(CustomButtonCommandProperty); }
            set
            {
                SetValue(CustomButtonCommandProperty, value);
            }
        }

        public CustomButton1()
        {
            InitializeComponent();
            CustomTitle = "CustomButton";
            CustomIcon = "ArrowDownBoldCircleOutline";
        }
    }
}
