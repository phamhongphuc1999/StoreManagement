using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class ControlBarViewModel: BaseViewModel
    {
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseLeftButtonDownCommand { get; set; }

        public ControlBarViewModel()
        {
            InitializeCloseCommand();
            InitializeMaximizeCommand();
            InitializeMinimizeCommand();
            InitializeMouseLeftButtonDownCommand();
        }

        private void InitializeCloseCommand()
        {
            CloseWindowCommand = new RelayCommand<UserControl>(
                sender =>
                {
                    return sender == null ? false : true;
                },
                sender =>
                {
                    FrameworkElement root = GetRootParent(sender);
                    Window window = root as Window;
                    if (window != null) window.Close();
                });
        }

        private void InitializeMaximizeCommand()
        {
            MaximizeWindowCommand = new RelayCommand<UserControl>(
                sender =>
                {
                    return sender == null ? false : true;
                },
                sender =>
                {
                    FrameworkElement root = GetRootParent(sender);
                    Window window = root as Window;
                    if (window != null)
                    {
                        if (window.WindowState != WindowState.Maximized) window.WindowState = WindowState.Maximized;
                        else window.WindowState = WindowState.Normal;
                    }
                });
        }

        private void InitializeMinimizeCommand()
        {
            MinimizeWindowCommand = new RelayCommand<UserControl>(
                sender =>
                {
                    return sender == null ? false : true;
                },
                sender =>
                {
                    FrameworkElement root = GetRootParent(sender);
                    Window window = root as Window;
                    if (window != null) window.WindowState = WindowState.Minimized;
                });
        }

        private void InitializeMouseLeftButtonDownCommand()
        {
            MouseLeftButtonDownCommand = new RelayCommand<UserControl>(
                sender =>
                {
                    return sender == null ? false : true;
                },
                sender =>
                {
                    FrameworkElement root = GetRootParent(sender);
                    Window window = root as Window;
                    if (window != null) window.DragMove();
                });
        }

        private FrameworkElement GetRootParent(UserControl control)
        {
            FrameworkElement parent = control;
            while (parent.Parent != null)
                parent = parent.Parent as FrameworkElement;
            return parent;
        }
    }
}
