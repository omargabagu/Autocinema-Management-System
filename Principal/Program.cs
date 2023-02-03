using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Principal
{

    public static class Global
    {
        public static List<Usuario> BaseUsuarios = new List<Usuario>();
        public static List<Complementos> baseComplementos = new List<Complementos>();
        public static funcion[] lista = new funcion[3] { new funcion("The Batman", "16:30 pm", "2h 56m", "Matt Reeves", "PG-13", "8.1/10", global::Principal.Properties.Resources.batman), new funcion("Solo", "12:00 am", "2h 15m", "Ron Howard", "PG-13", "8.6/10", global::Principal.Properties.Resources.solo), new funcion("Logan", "2:30 pm", "2h 17m", "James Mangold", "R", "8.5/10", Properties.Resources.logan) };
        public static int cantUsuarios = 0;
        public static Usuario usuarioEntrante;
        public static int numVenta = 0;
        public static List<funcion> baseFuncion = new List<funcion>();
    }


    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static Portada portada;

        [STAThread]
        static void Main()
        {

            //Instancia de Complementos

            Global.baseComplementos.Add(new Complementos("FS001", "Refresco Grande", 45));
            Global.baseComplementos.Add(new Complementos("FS002", "Hot Dog", 40));
            Global.baseComplementos.Add(new Complementos("FS003", "Palomitas Grandes", 70));
            Global.baseComplementos.Add(new Complementos("FS004", "Icee", 55));
            Global.baseComplementos.Add(new Complementos("FS005", "Nachos", 70));
            Global.baseComplementos.Add(new Complementos("FS006", "Refresco Mediano", 38));
            Global.baseComplementos.Add(new Complementos("FS007", "Palomitas medianas",58 ));
            Global.baseComplementos.Add(new Complementos("FS008", "Refresco Chico", 32));
            Global.baseComplementos.Add(new Complementos("FS009", "Palomitas Chicas", 46));
            Global.baseComplementos.Add(new Complementos("FS010", "Chocolates", 34));

     

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(portada = new Portada());
        }


       


    }
}
