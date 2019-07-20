using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Datos;

namespace OnBreak.Negocios
{
    public class Contrato
    {
        #region Campo
        private string _numero;
        private DateTime _creacion;
        private DateTime _term;
        private string _rutcli;
        private string _modalidad;
        private TipoEvento _tipoevento;
        private CoffeeBreak _cafe;
        private Cocktail _coc;
        private Cenas _cena;
        private DateTime _fechahorain;
        private DateTime _fechahorafin;
        private int _asistentes;
        private int _adicional;
        private Boolean _realizado;
        private double _valortotal;
        private string _observacion;
        #endregion
        #region Parametros
        public Cenas Cena
        {
            get
            {
                return _cena;
            }
            set
            {
                _cena = value;
            }
        }
        public Cocktail Coc
        {
            get
            {
                return _coc;
            }
            set
            {
                _coc = value;
            }
        }
        public CoffeeBreak Cafe
        {
            get
            {
                return _cafe;
            }
            set
            {
                _cafe = value;
            }
        }
        public TipoEvento Tipos
        {
            get
            {
                return _tipoevento;
            }
            set
            {
                _tipoevento = value;
            }
        }
        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        public DateTime Creacion
        {
            get
            {
                return _creacion;
            }
            set
            {
                _creacion = value;
            }
        }
        public DateTime Termino
        {
            get
            {
                return _term;
            }
            set
            {
                _term = value;
            }
        }
        public string RutCliente
        {
            get
            {
                return _rutcli;
            }
            set
            {
                _rutcli = value;
            }
        }
        public string Modalidad
        {
            get
            {
                return _modalidad;
            }
            set
            {
                _modalidad = value;
            }
        }

        public DateTime FechaHoraInicio
        {
            get
            {
                return _fechahorain;
            }
            set
            {
                _fechahorain = value;
            }
        }
        public DateTime FechaHoraTermino
        {
            get
            {
                return _fechahorafin;
            }
            set
            {
                _fechahorafin = value;
            }
        }
        public int Asistentes
        {
            get
            {
                return _asistentes;
            }
            set
            {
                _asistentes = value;
            }
        }
        public int PersonalAdicional
        {
            get
            {
                return _adicional;
            }
            set
            {
                _adicional = value;
            }
        }
        public Boolean Realizado
        {
            get
            {
                return _realizado;
            }
            set
            {
                _realizado = value;
            }
        }
        public double ValorTotalContrato
        {
            get
            {
                return _valortotal;
            }
            set
            {
                _valortotal = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return _observacion;
            }
            set
            {
                _observacion = value;
            }
        }
        #endregion
        #region Constructor
        public Contrato()
        {
            _numero = string.Empty;
            _creacion = DateTime.Today;
            _term = DateTime.Today;
            _rutcli = string.Empty;
            _modalidad = string.Empty;
            _tipoevento = 0;
            _fechahorain = DateTime.Today;
            _fechahorafin = DateTime.Today;
            _asistentes = 0;
            _adicional = 0;
            _realizado = false;
            _valortotal = 0;
            _observacion = string.Empty;
        }
        public Contrato(string NumeroC, DateTime CreacionC, DateTime TermC, string RutcliC, string ModalidadC, int TipoeventoC, DateTime FechahorainC, DateTime FechahorafinC, int AsistentesC, int AdicionalC, Boolean RealizadoC, double ValortotalC, string ObservacionC)
        {
            this.Numero = NumeroC;
            this.Creacion = CreacionC;
            this.Termino = TermC;
            this.RutCliente = RutcliC;
            this.Modalidad = ModalidadC;
            int tip = (int)this.Tipos;
            tip = TipoeventoC;
            this.FechaHoraInicio = FechahorainC;
            this.FechaHoraTermino = FechahorafinC;
            this.Asistentes = AsistentesC;
            this.PersonalAdicional = AdicionalC;
            this.Realizado = RealizadoC;
            this.ValorTotalContrato = ValortotalC;
            this.Observaciones = ObservacionC;
        }
        #endregion
        #region CRUD
        public bool Create()
        {
            try
            {
                int tip = (int)this.Tipos;
                OnBreak.Datos.Contrato pae = new OnBreak.Datos.Contrato()
                {
                    Numero = this.Numero,
                    Creacion = this.Creacion,
                    Termino = this.Termino,
                    RutCliente = this.RutCliente,
                    IdModalidad = this.Modalidad,
                    IdTipoEvento = tip,
                    FechaHoraInicio = this.FechaHoraInicio,
                    FechaHoraTermino = this.FechaHoraTermino,
                    Asistentes = this.Asistentes,
                    PersonalAdicional = this.PersonalAdicional,
                    Realizado = this.Realizado,
                    ValorTotalContrato = this.ValorTotalContrato,
                    Observaciones = this.Observaciones
                };
                Conexion.Break.Contrato.Add(pae);
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
                int tip = (int)this.Tipos;
                OnBreak.Datos.Contrato pae = (from auxpae in Conexion.Break.Contrato
                                              where auxpae.Numero == this.Numero
                                              select auxpae).First();

                this.Creacion = pae.Creacion;
                this.Termino = pae.Termino;
                this.RutCliente = pae.RutCliente;
                this.Modalidad = pae.IdModalidad;
                tip = pae.IdTipoEvento;
                this.FechaHoraInicio = pae.FechaHoraInicio;
                this.FechaHoraTermino = pae.FechaHoraTermino;
                this.Asistentes = pae.Asistentes;
                this.PersonalAdicional = pae.PersonalAdicional;
                this.Realizado = pae.Realizado;
                this.ValorTotalContrato = pae.ValorTotalContrato;
                this.Observaciones = pae.Observaciones;
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
                int tip = (int)this.Tipos;
                OnBreak.Datos.Contrato pae = Conexion.Break.Contrato.First(p => p.Numero == Numero);

                pae.Numero = Numero;
                pae.Creacion = Creacion;
                pae.Termino = Termino;
                pae.RutCliente = RutCliente;
                pae.IdModalidad = Modalidad;
                pae.IdTipoEvento = tip;
                pae.FechaHoraInicio = FechaHoraInicio;
                pae.FechaHoraTermino = FechaHoraTermino;
                pae.Asistentes = Asistentes;
                pae.PersonalAdicional = PersonalAdicional;
                pae.Realizado = Realizado;
                pae.ValorTotalContrato = ValorTotalContrato;
                pae.Observaciones = Observaciones;

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
                OnBreak.Datos.Contrato pae = (from auxpae in Conexion.Break.Contrato
                                              where auxpae.Numero == this.Numero
                                              select auxpae).First();
                Conexion.Break.Contrato.Remove(pae);
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
