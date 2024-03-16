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

namespace Lab1_EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MakdoknekEntities dazabannix = new MakdoknekEntities();
        int flag = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).IsEnabled == true)
            {
                if (flag > 2)
                    flag = -1;
                flag++;
            }
            if (flag == 0)
                ClientDgr.ItemsSource = dazabannix.Client.ToList();
            if (flag == 1)
                ClientDgr.ItemsSource = dazabannix.Menu.ToList();
            if (flag == 2)
                ClientDgr.ItemsSource = dazabannix.Booking.ToList();
        }
    }
}
