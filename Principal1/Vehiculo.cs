using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Vehiculo
    {
        string marca;
        string modelo;
        string tipoAuto;
        string placas;
        int numPasajeros;

        public Vehiculo()
        {
            //vacio
        }

        public Vehiculo(string marca, string modelo, string tipoAuto, string placas, int numPasajeros)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.TipoAuto = tipoAuto;
            this.Placas = placas;
            this.NumPasajeros = numPasajeros;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string TipoAuto { get => tipoAuto; set => tipoAuto = value; }
        public string Placas { get => placas; set => placas = value; }
        public int NumPasajeros { get => numPasajeros; set => numPasajeros = value; }
    }
}
