using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        private static DependencyProperty CustomTitleProperty = DependencyProperty.Register(
            "CustomTitle", typeof(string), typeof(CustomButton));
        public string CustomTitle
        {
            get { return (string)GetValue(CustomTitleProperty); }
            set
            {
                SetValue(CustomTitleProperty, value);
            }
        }

        private static DependencyProperty CustomIconProperty = DependencyProperty.Register(
            "CustomIcon", typeof(string), typeof(CustomButton));
        public string CustomIcon
        {
            get { return (string)GetValue(CustomIconProperty); }
            set
            {
                SetValue(CustomIconProperty, value);
            }
        }


        public static DependencyProperty CustomButtonCommandProperty = DependencyProperty.Register(
            "CustomButtonCommand", typeof(ICommand), typeof(CustomButton));

        public ICommand CustomButtonCommand
        {
            get { return (ICommand)GetValue(CustomButtonCommandProperty); }
            set
            {
                SetValue(CustomButtonCommandProperty, value);
            }
        }

        public CustomButton()
        {
            InitializeComponent();
            CustomTitle = "CustomButton";
            CustomIcon = "ArrowDownBoldCircleOutline";
        }
    }
}
