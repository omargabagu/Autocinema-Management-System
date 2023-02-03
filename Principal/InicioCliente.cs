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
    public partial class InicioCliente : Form
    {

       

        public InicioCliente()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();
        }



        public void ConfiguracionInicial()
        {
            
            lblTitulo.Text = "";
            lblHorario.Text = "Hora de inicio: ";
            lblDirector.Text = "Director: ";
            lblDuracion.Text = "Duración: ";
            lblClasificacion.Text = "Clasificación: ";
            lblResegna.Text = "Reseña: ";
            for (int i = 0; i < Global.lista.Length; i++)
            {
                comboBox1.Items.Add(Global.lista[i].Nombre + " " + Global.lista[i].Horario);

            }

            lblNombre.Text = "Nombre: " + Global.usuarioEntrante.Nombre;
            lbId.Text = "ID: " + Global.usuarioEntrante.Id;


        }

        public void actualizarPelicula()
        {
            lblTitulo.Text = Global.lista[comboBox1.SelectedIndex].Nombre;
            lblHorario.Text = "Hora de inicio: " + Global.lista[comboBox1.SelectedIndex].Horario;
            lblDirector.Text = "Director: " + Global.lista[comboBox1.SelectedIndex].Director;
            lblDuracion.Text = "Duración: " + Global.lista[comboBox1.SelectedIndex].Duracion;
            lblClasificacion.Text = "Clasificación: " + Global.lista[comboBox1.SelectedIndex].Clasificacion;
            lblResegna.Text = "Reseña: " + Global.lista[comboBox1.SelectedIndex].Resena;
            pictureBox2.Image = Global.lista[comboBox1.SelectedIndex].imagen;
        }

        /*
        private void InicioCliente_Load(object sender, EventArgs e)
        {
           
            lblTitulo.Text = "";
            lblHorario.Text = "Hora de inicio: ";
            lblDirector.Text = "Director: ";
            lblDuracion.Text = "Duración: ";
            lblClasificacion.Text = "Clasificación: ";
            lblResegna.Text = "Reseña: ";
            for (int i = 0; i < Global.lista.Length; i++)
            {
                comboBox1.Items.Add(Global.lista[i].nombre + " " + Global.lista[i].horario);

            }
        }*/


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPelicula();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarBoletos_Click(object sender, EventArgs e)
        {
            this.Close();
            ComprarBoletos comprarBoletos = new ComprarBoletos();
            comprarBoletos.Show();
        }

        private void InicioCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            using (CrearCuenta ventana = new CrearCuenta(1))
                ventana.ShowDialog();
            ConfiguracionInicial();
        }

        private void btnVerBoletos_Click(object sender, EventArgs e)
        {
            using (VerBoleto ventana = new VerBoleto())
                ventana.ShowDialog();
        }

        private void btnVerRecibo_Click(object sender, EventArgs e)
        {
            using (VerRecibos ventana = new VerRecibos())
                ventana.ShowDialog();
        }
    }
}
