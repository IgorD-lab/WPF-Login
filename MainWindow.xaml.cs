using System.Windows;
using System.Windows.Media;

namespace Sign_Up_Form
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Switch to Login view
            SignUpPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;

            // Change button styles
            SignUpButton.Background = Brushes.Transparent;
            SignUpButton.Foreground = Brushes.Black;
            LoginButton.Background = new SolidColorBrush(Color.FromRgb(0x1A, 0x5F, 0x7A));
            LoginButton.Foreground = Brushes.White;
        }
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Switch to Sign Up view
            LoginPanel.Visibility = Visibility.Collapsed;
            SignUpPanel.Visibility = Visibility.Visible;

            // Change button styles
            LoginButton.Background = Brushes.Transparent;
            LoginButton.Foreground = Brushes.Black;
            SignUpButton.Background = new SolidColorBrush(Color.FromRgb(0x1A, 0x5F, 0x7A));
            SignUpButton.Foreground = Brushes.White;
        }
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // This method allows dragging the window
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
                DragMove();
        }
    }
}