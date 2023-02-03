using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class VerBoleto : Form
    {
        public VerBoleto()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {
            if(Global.usuarioEntrante.CostoBoleto != 0)
            {
                lblUsuario.Text = "Horario: " + Global.usuarioEntrante.Nombre;
                lblCorreo.Text = "Correo: " + Global.usuarioEntrante.Correo;
                lblPelicula.Text = "Pelicula: " + Global.lista[Global.usuarioEntrante.IdPelicula].Nombre;
                lblHorario.Text = "Horario: " + Global.lista[Global.usuarioEntrante.IdPelicula].Horario;
                lblVehiculo.Text = "Tipo de Vehiculo: " + Global.usuarioEntrante.VehiculoUs.TipoAuto;
                lblCosto.Text = "Costo Boleto: " + Global.usuarioEntrante.CostoBoleto;

            }
            else
            {
                MessageBox.Show("No se ha comprano ningun boleto aun");
            }


        }

        private void VerBoleto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
