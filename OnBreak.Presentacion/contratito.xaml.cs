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
    public partial class Contratito : MetroWindow
    {
        public Contratito()


        {
            InitializeComponent();
            cmb1.ItemsSource = Enum.GetValues(typeof(TipoEvento));
            cmb1.SelectedValue = TipoEvento.CoffeeBreak;
        }

        private void Cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int likes = cmb1.SelectedIndex;
            if (likes.Equals(0))
            {
                cmb2.ItemsSource = Enum.GetValues(typeof(CoffeeBreak));
                cmb2.SelectedValue = CoffeeBreak.LightBreak;
            }
            if (likes.Equals(1))
            {
                cmb2.ItemsSource = Enum.GetValues(typeof(Cocktail));
                cmb2.SelectedValue = Cocktail.QuickCocktail;
            }
            if (likes.Equals(2))
            {
                cmb2.ItemsSource = Enum.GetValues(typeof(Cenas));
                cmb2.SelectedValue = Cenas.celebracion;
            }
        }

        private void Btn_Agregar_Click(object sender, RoutedEventArgs e)
        {
            Manejadora _awa = new Manejadora();
            double uf = _awa.CalculoUF();
            double adi1 = 0;
            double adi = 0;
            string ip = txt_Asistentes.Text;
            int y = int.Parse(ip);
            string op = txt_Adicional.Text;
            int x = int.Parse(op);
            if (uf==3 || uf==8 || uf==12 )
            {
                if (x == 2) { adi1 = 2; }
                if (x == 3) { adi1 = 3; }
                if (x == 4) { adi1 = 3.5; }
                if (x > 4) { adi1 = 3.5 + ((x - 4) * 0.5); }
                if (y > 0 && y < 21)
                {
                    adi = uf + 3 + adi1 ;
                }
                if (y > 20  && y < 51)
                {
                    adi = uf + 5 + adi1;
                }
                if (y > 50)
                {
                    adi = uf + (y / 20*2) + adi1;
                }
            }
            if (uf == 6 || uf == 10 )
            {
                if (x == 2) { adi1 = 2; }
                if (x == 3) { adi1 = 3; }
                if (x == 4) { adi1 = 3.5; }
                if (x > 4) { adi1 = 3.5 + ((x - 4) * 0.5); }
                if (y > 0 && y < 21)
                {
                    adi = uf + 4 + adi1 ;
                }
                if (y > 20 && y < 51)
                {
                    adi = uf + 6 + adi1;
                }
                if (y > 50)
                {
                    adi = uf + (y / 20 * 2+ adi1);
                }
            }
            if (uf == 25 || uf == 35)
            {
                if (x == 2) { adi1 = 3; }
                if (x == 3) { adi1 = 4; }
                if (x == 4) { adi1 = 5; }
                if (x > 4) { adi1 = 5 + ((x - 4) * 0.5); }
                if (y > 0 && y < 21)
                {
                    adi = uf + (y * 1.5) + adi1;
                }
                if (y > 20 && y < 51)
                {
                    adi = uf + (y * 1.2) + adi1;
                }
                if (y > 50)
                {
                    adi = uf + (y * 1) + adi1;
                }
            }

            Contrato contra = new Contrato()
            {
                Numero = DateTime.Now.ToString("AAAAMMDDHHmm"),
                Creacion = DateTime.Now,
                Termino = DateTime.Parse(txt_TerminoCon.Text),
                RutCliente = txt_Rut.Text,
                Modalidad = cmb2.SelectedItem.ToString(),
                Tipos = (TipoEvento)cmb1.SelectedValue,
                FechaHoraInicio = DateTime.Parse(txt_InicioCon.Text),
                FechaHoraTermino = DateTime.Parse(txt_TerminoCon.Text),
                Asistentes = y,
                PersonalAdicional = x,
                Realizado = true,
                ValorTotalContrato = adi,
                Observaciones = txt_Observaciones.Text
            };
            if  (contra.Create())
            {
                MessageBox.Show("Contrato Generado, Total a pagar: " + adi + "UF", 
                                "Asistentes: " + y);
            }
            else
            {
                MessageBox.Show("Error al generar el contrato", "Atencion", MessageBoxButton.OK);
            }
            /*Contrato _contra = new Contrato();
            try
            {
                _contra.Numero = DateTime.Now.ToString("AAAAMMDDHHmm");
                _contra.Creacion = DateTime.Now;
                _contra.RutCliente = txt_Rut.Text;
                _contra.Modalidad = cmb2.Text;
                _contra.Tipos = (TipoEvento)cmb1.SelectedItem; ;
                _contra.FechaHoraInicio = DateTime.Parse(txt_InicioCon.Text);
                _contra.FechaHoraTermino = DateTime.Parse(txt_TerminoCon.Text);
                _contra.Asistentes = y;
                _contra.PersonalAdicional = x;
                _contra.Observaciones = txt_Observaciones.Text;
                _contra.ValorTotalContrato = adi;

                MessageBox.Show("Contrato Generado, Total a pagar: " + adi + "UF",
                                "Asistentes: " + y);
            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }*/

        }

        private void Btn_Volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}