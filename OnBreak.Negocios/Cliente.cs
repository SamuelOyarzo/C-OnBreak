using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public class Cliente
    { 
        #region Campos
    private string _rut;
    private string _razonsocial;
    private string _nombrecontacto;
    private string _email;
    private string _direccion;
    private string _telefono;
    private ActividadEmpresa _idactividadempresa;
    private TipoEmpresa _idtipoempresa;

    #endregion
    #region Propiedades


    public ActividadEmpresa Actividad
    {
        get
        {
            return _idactividadempresa;
        }
        set
        {
            _idactividadempresa = value;
        }
    }

    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
        }
    }
    public string Direccion
    {
        get
        {
            return _direccion;
        }
        set
        {
            _direccion = value;
        }
    }
    public string Telefono
    {
        get
        {
            return _telefono;
        }
        set
        {
            _telefono = value;
        }
    }
    public TipoEmpresa Tipo
    {
        get
        {
            return _idtipoempresa;
        }
        set
        {
            _idtipoempresa = value;
        }
    }

    public string Razon
    {
        get
        {
            return _razonsocial;
        }
        set
        {
            _razonsocial = value;
        }
    }
    public string Rut
    {
        get
        {
            return _rut;
        }
        set
        {
            _rut = value;
        }
    }
    public string Nombre
    {
        get
        {
            return _nombrecontacto;
        }
        set
        {
            _nombrecontacto = value;
        }
    }
    #endregion
    #region Constructor
    public Cliente()
    {

        _rut = string.Empty;
        _razonsocial = string.Empty;
        _nombrecontacto = string.Empty;
        _email = string.Empty;
        _direccion = string.Empty;
        _telefono = string.Empty;
        _idactividadempresa = 0;
        _idtipoempresa = 0;
    }
    public Cliente(string RutC, string RazonC, string NombreC, string EmailC, string DireccionC, string TelefonoC, int idActividadC, int idTipoC)
    {
        this.Rut = RutC;
        this.Razon = RazonC;
        this.Nombre = NombreC;
        this.Email = EmailC;
        this.Direccion = DireccionC;
        this.Telefono = TelefonoC;
        int acti = (int)this.Actividad;
        acti = idActividadC;
        int tip = (int)this.Tipo;
        tip = idTipoC;
    }
    #endregion
    #region CRUD
    public bool Create()
    {
        try
        {
            int acti1 = (int)this.Actividad;
            int tip1 = (int)this.Tipo;
            OnBreak.Datos.Cliente paa = new OnBreak.Datos.Cliente()
            {
                RutCliente = this.Rut,
                RazonSocial = this.Razon,
                NombreContacto = this.Nombre,
                MailContacto = this.Email,
                Direccion = this.Direccion,
                Telefono = this.Telefono,
                IdActividadEmpresa = acti1,
                IdTipoEmpresa = tip1
            };
            Conexion.Break.Cliente.Add(paa);
            Conexion.Break.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Read()
    {
        try
        {
            int acti1 = (int)this.Actividad;
            int tip1 = (int)this.Tipo;

            OnBreak.Datos.Cliente paa = (from auxpaa in Conexion.Break.Cliente
                                         where auxpaa.RutCliente == this.Rut
                                         select auxpaa).First();

            this.Razon = paa.RazonSocial;
            this.Nombre = paa.NombreContacto;
            this.Email = paa.MailContacto;
            this.Direccion = paa.Direccion;
            this.Telefono = paa.Telefono;
            acti1 = paa.IdActividadEmpresa;
            tip1 = paa.IdTipoEmpresa;
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Update()
    {
        try
        {
            int acti1 = (int)this.Actividad;
            int tip1 = (int)this.Tipo;

            OnBreak.Datos.Cliente paa = Conexion.Break.Cliente.First(p => p.RutCliente == Rut);

            paa.NombreContacto = Nombre;
            paa.RutCliente = Rut;
            paa.RazonSocial = Razon;
            paa.MailContacto = Email;
            paa.Direccion = Direccion;
            paa.Telefono = Telefono;
            paa.IdActividadEmpresa = acti1;
            paa.IdTipoEmpresa = tip1;

            Conexion.Break.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Delete()
    {
        try
        {
            OnBreak.Datos.Cliente paa = (from auxpaa in Conexion.Break.Cliente
                                         where auxpaa.RutCliente == this.Rut
                                         select auxpaa).First();
            Conexion.Break.Cliente.Remove(paa);
            Conexion.Break.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    #endregion
}
}
