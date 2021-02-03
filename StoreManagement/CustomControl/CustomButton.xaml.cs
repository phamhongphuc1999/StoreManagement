using System.ComponentModel;
using System.Windows.Controls;

namespace StoreManagement.CustomControl
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl, INotifyPropertyChanged
    {
        private string customTitle;
        public string CustomTitle
        {
            get { return customTitle; }
            set
            {
                customTitle = value;
                OnPropertyChanged("CustomTitle");
            }
        }

        private string customIcon;
        public string CustomIcon
        {
            get { return customIcon; }
            set
            {
                customIcon = value;
                OnPropertyChanged("CustomIcon");
            }
        }

        public CustomButton()
        {
            InitializeComponent();
            this.DataContext = this;
            CustomTitle = "CustomButton";
            CustomIcon = "ArrowDownBoldCircleOutline";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
    }
}
