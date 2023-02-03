using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class TarjetaCredito : Form
    {
        public TarjetaCredito()
        {
            InitializeComponent();
            ConfiguracionIncicial();
        }

        private void ConfiguracionIncicial()
        {
            btnPagar.Enabled = false;
        }

        private void actualizar()
        {
            if(txtBanco.Text.Length>3 && txtNumTarjeta.Text.Length>2 && txtSaldo.Text.Length>0 && txtCodigoVerificacion.Text.Length > 3)
            {
                btnPagar.Enabled=true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtNumTarjeta_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtTipoTarjeta_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtCodigoVerificacion_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Global.usuarioEntrante.TarjetaUs = new Tarjeta( Convert.ToSingle(txtSaldo.Text), txtNumTarjeta.Text, txtTipoTarjeta.Text, txtBanco.Text, txtCodigoVerificacion.Text);
            Global.numVenta++;
            Escribir();
            MessageBox.Show("Se ha ingresado correctamente la tarjeta de credito");
            this.Close();
        
        }


        private void Escribir()
        {
                TextWriter escribir = new StreamWriter("compra_"+Global.usuarioEntrante.Id+"_"+Global.numVenta+".txt");
                escribir.WriteLine("Nombre: " + Global.usuarioEntrante.Nombre);
                escribir.WriteLine("Apellido Paterno: {0}   Apellido Materno: {1}",Global.usuarioEntrante.APP,Global.usuarioEntrante.APM);
                escribir.WriteLine("Correo: " + Global.usuarioEntrante.Correo);
                escribir.WriteLine("Contraseña: " + Global.usuarioEntrante.Contrasegna);
                escribir.WriteLine("Direccion {0}  Telefono{1} ",Global.usuarioEntrante.Direccion,Global.usuarioEntrante.Celular);
            escribir.Close();
            
            
        }
    }
}
