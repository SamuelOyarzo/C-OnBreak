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
    /// Lógica de interacción para TabControl.xaml
    /// </summary>
    public partial class TabControl : MetroWindow
    {
        Cliente _mane = new Cliente();
        Manejadora _awa = new Manejadora();
        public TabControl()
        {
            InitializeComponent();
            cmbActividad.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cmbActividad.SelectedValue = ActividadEmpresa.Agropecuaria;
            cmbTipo.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));
            cmbTipo.SelectedValue = TipoEmpresa.EIRL;
        }
        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _mane.Rut = txtRut.Text;
                _mane.Razon = txtRazon_social.Text;
                _mane.Nombre = txtNombre.Text;
                _mane.Email = txtMail.Text;
                _mane.Direccion = txtAddress.Text;
                _mane.Telefono = txtFono.Text;
                _mane.Actividad = (ActividadEmpresa)cmbActividad.SelectedItem;
                _mane.Tipo = (TipoEmpresa)cmbTipo.SelectedItem;
                MessageBox.Show("Usuario Registrado con Exito");
            }
            catch(Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid2.Background = Grid2.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
            Grid2_2.Background = Grid2_2.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
            Grid2_3.Background = Grid2_3.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
            Grid2_4.Background = Grid2_4.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
            Grid2_5.Background = Grid2_5.Background == Brushes.Black ? (SolidColorBrush)(new BrushConverter().ConvertFrom("White")) : Brushes.Black;
        }

        private void Volver1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
