using System.Windows;

namespace StoreManagement.CustomAttachedProperties
{
    public class ExtensionInfo
    {
        public static readonly DependencyProperty CustomIconProperty =
            DependencyProperty.RegisterAttached("CustomIcon", typeof(string), typeof(ExtensionInfo), new PropertyMetadata(default(string)));

        public static void SetCustomIcon(UIElement element, string value)
        {
            element.SetValue(CustomIconProperty, value);
        }

        public static string GetCustomIcon(UIElement element)
        {
            return (string)element.GetValue(CustomIconProperty);
        }

        public static readonly DependencyProperty CustomTitleProperty =
            DependencyProperty.RegisterAttached("CustomTitle", typeof(string), typeof(ExtensionInfo), new PropertyMetadata(default(string)));
    
        public static void SetCustomTitle(UIElement element, string value)
        {
            element.SetValue(CustomTitleProperty, value);
        }

        public static string GetCustomTitle(UIElement element)
        {
            return (string)element.GetValue(CustomTitleProperty);
        }
    }
}
