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
using OnBreak.Negocios;
using MahApps.Metro.Controls;

namespace OnBreak.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Grid1.Background = Grid1.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
            TitleOnbreak.Foreground = TitleOnbreak.Foreground == Brushes.White ? (SolidColorBrush)(new BrushConverter().ConvertFrom("Black")) : Brushes.White;


            if (OnBreak1.Visibility is Visibility.Visible)
            {
                OnBreak1.Visibility = Visibility.Hidden;
                OnBreak2.Visibility = Visibility.Visible;
            }
            else
            {
                OnBreak1.Visibility = Visibility.Visible;
                OnBreak2.Visibility = Visibility.Hidden;
            }
            
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            TabControl TabControl1 = new TabControl();
            TabControl1.Show();
            this.Close();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Lista_Clientes List = new Lista_Clientes();
            List.Show();
            this.Close();
        }
    }
}
