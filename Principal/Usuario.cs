using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Usuario
    {
        bool admin = false;
        bool compra = false; //indica si el usuario ya ha realizado la compra de su boleto
        string nombre;
        string aPM, aPP;
        string correo;
        string contrasegna;
        string celular;
        string direccion;
        int id;
        float total;
        float costoBoleto;
        Tarjeta tarjetaUs;
        Vehiculo vehiculoUs;
        List<Complementos> listaComplementos;
        int idPelicula=0;

        public Usuario()
        {
            TarjetaUs = new Tarjeta();
            VehiculoUs = new Vehiculo();
            ListaComplementos = new List<Complementos>();
        }

        public Usuario(string nombre,string aPM, string aPP, string correo, string contrasegna, string celular, string direccion, int id)
        {
            this.Nombre = nombre;
            this.APM = aPM;
            this.APP = aPP;
            this.Correo = correo;
            this.Contrasegna = contrasegna;
            this.Celular = celular;
            this.Direccion = direccion;
            this.Id = id;
            Total = 0;
            TarjetaUs = new Tarjeta();
            VehiculoUs = new Vehiculo();
            ListaComplementos = new List<Complementos>();
        }

        public bool Admin { get => admin; set => admin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string APM { get => aPM; set => aPM = value; }
        public string APP { get => aPP; set => aPP = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasegna { get => contrasegna; set => contrasegna = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public bool Compra { get => compra; set => compra = value; }
        public float Total { get => total; set => total = value; }
        public float CostoBoleto { get => costoBoleto; set => costoBoleto = value; }
        internal Tarjeta TarjetaUs { get => tarjetaUs; set => tarjetaUs = value; }
        internal Vehiculo VehiculoUs { get => vehiculoUs; set => vehiculoUs = value; }
        internal List<Complementos> ListaComplementos { get => listaComplementos; set => listaComplementos = value; }
    }
}
