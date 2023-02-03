using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Complementos
    {
        string id;
        string nombre;
        float costo;

        public Complementos()
        {
            //vacio
        }

        public Complementos(string id, string nombre, float costo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Costo = costo;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Costo { get => costo; set => costo = value; }
    }
}
