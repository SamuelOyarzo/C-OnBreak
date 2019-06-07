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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using OnBreak.Negocios;

namespace OnBreak.Presentacion
{
    /// <summary>
    /// Lógica de interacción para Lista_Clientes.xaml
    /// </summary>
    public partial class Lista_Clientes : MetroWindow
    {
        Cliente _mane = new Cliente();
        Manejadora _awa = new Manejadora();
        public Lista_Clientes()
        {
            InitializeComponent();
        }

        private void Volver1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid3.Background = Grid3.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
        }
    }
}
