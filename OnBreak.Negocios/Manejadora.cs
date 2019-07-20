using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public class Manejadora
    {
        public List<Cliente> ListarClientes(Cliente cliente)
        {
            List<Cliente> ListaClientes = new List<Cliente>();
            foreach (OnBreak.Datos.Cliente clie in Conexion.Break.Cliente)
            {
                Cliente nuevoCliente = new Cliente(clie.RutCliente, clie.RazonSocial, clie.NombreContacto, clie.MailContacto, clie.Direccion, clie.Telefono, clie.IdActividadEmpresa, clie.IdTipoEmpresa);
                ListaClientes.Add(nuevoCliente);
            }
            return ListaClientes;
        }
        public List<Contrato> ListarContratos(Contrato contrato)
        {
            List<Contrato> ListarContratos = new List<Contrato>();
            foreach (OnBreak.Datos.Contrato contra in Conexion.Break.Contrato)
            {
                Contrato nuevoContrato = new Contrato(contra.Numero, contra.Creacion, contra.Termino, contra.RutCliente, contra.IdModalidad, contra.IdTipoEvento, contra.FechaHoraInicio, contra.FechaHoraTermino, contra.Asistentes, contra.PersonalAdicional, contra.Realizado, contra.ValorTotalContrato, contra.Observaciones);
                ListarContratos.Add(nuevoContrato);
            }
            return ListarContratos;
        }
        Contrato _contra = new Contrato();
        int uf = 0;
        public int CalculoUF()
        {
            if (CoffeeBreak.LightBreak == 0)
            {
                uf = 3;

            }
            else if (CoffeeBreak.JournalBreak == 0)
            {
                uf = 8;

            }
            else if (CoffeeBreak.DayBreak == 0)
            {
                uf = 12;

            }
            else if (Cocktail.QuickCocktail == 0)
            {
                uf = 6;
            }
            else if (Cocktail.AmbientCocktail == 0)
            {
                uf = 10;
            }
            else if (Cenas.ejecutiva == 0)
            {
                uf = 25;
            }
            else if (Cenas.celebracion == 0)
            {
                uf = 35;
            }
            else
            {
                uf = 0;
            }
            return uf;

        }
    }
}
