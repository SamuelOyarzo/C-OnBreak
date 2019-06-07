using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Break.Datos;

namespace OnBreak.Negocios
{
    public class Manejadora
    {
        public List<Cliente> ListarClientes(Cliente cliente)
        {
            List<Cliente> ListaClientes = new List<Cliente>();
            foreach (Break.Datos.Cliente clie in Conexion.Break.Cliente)
            {
                Cliente nuevoCliente = new Cliente(clie.RutCliente, clie.RazonSocial, clie.NombreContacto, clie.MailContacto, clie.Direccion,clie.Telefono,clie.IdActividadEmpresa,clie.IdTipoEmpresa);
                ListaClientes.Add(nuevoCliente);
            }
            return ListaClientes;
        }
    }
}

