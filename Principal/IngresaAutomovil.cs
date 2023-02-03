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
    public partial class IngresaAutomovil : Form
    {
        public int selection; //indicara la posicion en donde el usuario desea comprar el boleto
        public int idPelicula; //indica el id de la Pelicula
        public IngresaAutomovil(int pos,int numP)
        {
            InitializeComponent();
            selection = pos;
            idPelicula = numP;
            ConfiguracionInicial();
        }

        //configuracion inicial del form
        private void ConfiguracionInicial()
        {
            btnSiguiente.Enabled = false;
        }

        //conforme se escribe en el form se debe de ir actualizando para verificar si ya estan completos los datos
        private void Actualizar()
        {
            if(txtMarca.Text.Length>3 && txtModelo.Text.Length>3 && txtNumPasajeros.Text.Length>0 && txtPlacas.Text.Length>6 && comboBox1.Text.Length>0)
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IngresaAutomovil_Load(object sender, EventArgs e)
        {

        }

        //solo si se aprieta el boton siguiente indicará que la compra del boleto esta asegurada
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            Global.usuarioEntrante.IdPelicula = idPelicula; 
            Global.lista[idPelicula].Lugar[selection] = false; //coloca como ocupado el asiento ubicado en selection de la lista global de funciones
            Global.usuarioEntrante.VehiculoUs = new Vehiculo(txtMarca.Text, txtModelo.Text, comboBox1.Text, txtPlacas.Text, Convert.ToInt32(txtNumPasajeros.Text)); //se instancia un objeto vehiculo con la informacion del form
            Global.usuarioEntrante.Compra = true;
            if(comboBox1.Text == "Auto")
            {
                Global.usuarioEntrante.Total = 350;
                Global.usuarioEntrante.CostoBoleto = 350;
                MessageBox.Show("El precio a pagar del boleto es: " + Global.usuarioEntrante.Total);
            }
            else if(comboBox1.Text == "Camioneta")
            {
                Global.usuarioEntrante.Total = 475;
                Global.usuarioEntrante.CostoBoleto = 475;
                MessageBox.Show("El precio a pagar del boleto es: " + Global.usuarioEntrante.Total);
            }
            MessageBox.Show("Se ha guardado con exito tu compra y la informacion del vehiculo");
            this.Close();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtTipoAuto_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtPlacas_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtNumPasajeros_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancela la compra");
            this.Close();
        }
    }
}
