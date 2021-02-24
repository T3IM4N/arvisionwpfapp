using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kzsystemwpfapp
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            headerborder.Visibility = Visibility.Visible;
            sidebarborder.Visibility = Visibility.Visible;
            footerborder.Visibility = Visibility.Visible;
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimizebutton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void sidebaropened_Click(object sender, RoutedEventArgs e)
        {
            sidebar.Width = 250;
            sidebarborder.Width = 250;
            sidebarclosed.Visibility = Visibility.Visible;
            sidebaropened.Visibility = Visibility.Hidden;
        }
        private void sidebarclosed_Click(object sender, RoutedEventArgs e)
        {
            sidebar.Width = 64;
            sidebarborder.Width = 64;
            sidebarclosed.Visibility = Visibility.Hidden;
            sidebaropened.Visibility = Visibility.Visible;
        }
    }
}
