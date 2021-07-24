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

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = new BitmapImage(
                new Uri(@"/Images;component/Images/text fairy tail anime happy fairy tail_www.animalhi.com_19.jpg", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Successful login!");
        }
    }
}
