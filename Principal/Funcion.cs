using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Principal
{
    public class funcion
    {
        /*Nombre de la película, horario,
        duración, director, clasificación y reseña*/
        private string resena;
        int idFuncion;
        private bool[] lugar = new bool[15];
        public System.Drawing.Image imagen;
        private string nombre;
        private string horario;
        private string duracion;
        private string director;
        private string clasificacion;

        public int IdFuncion { get => idFuncion; set => idFuncion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Director { get => director; set => director = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public string Resena { get => resena; set => resena = value; }
        public bool[] Lugar { get => lugar; set => lugar = value; }

        public funcion(string nombre, string horario, string duracion, string director, string clasificacion, string resena, System.Drawing.Image imagen)
        {
            this.Nombre = nombre;
            this.Horario = horario;
            this.Duracion = duracion;
            this.Director = director;
            this.Clasificacion = clasificacion;
            this.Resena = resena;
            this.imagen = imagen;
            try
            {
                this.imagen = imagen;
            }
            catch (Exception ex)
            {
                this.imagen = global::Principal.Properties.Resources.noimage_poster;

            }
            vaciarFuncion();
           
        }

        //realiza el procedimiento de vaciado/pone todos los lugares disponibles
        public void vaciarFuncion()
        {
            for (int i = 0; i < Lugar.Length; i++)
            {
                Lugar[i] = true;
            }
        }

    }
}
