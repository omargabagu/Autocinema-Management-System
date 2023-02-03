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
    public partial class EditarCartelera : Form
    {
        public EditarCartelera()
        {
            InitializeComponent();
            InstanciaFunciones();
            ConfiguracionInicial();
        }

        private void EditarCartelera_Load(object sender, EventArgs e)
        {

        }

        public void ConfiguracionInicial()
        {
            lblTitulo.Text = "";
            lblHorario.Text = "Hora de inicio: ";
            lblDirector.Text = "Director: ";
            lblDuracion.Text = "Duración: ";
            lblClasificacion.Text = "Clasificación: ";
            lblResegna.Text = "Reseña: ";
            for (int i = 0; i < Global.baseFuncion.Count; i++)
            {
                comboBox1.Items.Add(Global.baseFuncion.ElementAt(i).Nombre + " " + Global.baseFuncion.ElementAt(i).Horario);

            }
        }

        public void actualizarPelicula()
        {
            lblTitulo.Text = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Nombre;
            lblHorario.Text = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Horario;
            lblDirector.Text = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Director;
            lblDuracion.Text = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Duracion;
            lblClasificacion.Text += Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Clasificacion;
            lblResegna.Text = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Resena;
            pictureBox1.Image = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).imagen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstanciaFunciones()
        {
            Global.baseFuncion.Add(new funcion("The Batman", "16:30 pm", "2h 56m", "Matt Reeves", "PG-13", "8.1/10", global::Principal.Properties.Resources.batman));
            Global.baseFuncion.Add(new funcion("Solo", "12:00 am", "2h 15m", "Ron Howard", "PG-13", "8.6/10", global::Principal.Properties.Resources.solo));
            Global.baseFuncion.Add(new funcion("Logan", "2:30 pm", "2h 17m", "James Mangold", "R", "8.5/10", Properties.Resources.logan));
            Global.baseFuncion.Add(new funcion("Violet", "10:00 am", "2h 20 min", "Taichi Ishidate", "B", "9.0/10", Properties.Resources.violet));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPelicula();
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            int controlador;
            controlador = Buscar();
            if(controlador == 0) //se puede ingresar en la cartelera
            {
                Global.lista[0] = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex);
                MessageBox.Show("Cambios realizados con exito");
            }
            else
            {
                MessageBox.Show("No se puede colocar esta pelicula ya que se encuentra en otra funcion");
            }
        }


        //determina si el elemto que esta porpuesto para agregarse a la cartelera ya existe
        //retorn 1 en caso de que ya exita el elemento  en la cartelera
        //retorna 0 si no se encuentra en la cartelera
        private int Buscar()
        {
            for(int i=0; i<3; i++)
            {
                if (Global.lista[i].Nombre == Global.baseFuncion.ElementAt(comboBox1.SelectedIndex).Nombre)
                {
                    return 1;
                }
            }
            return 0;
        }

        private void btnElegir2_Click(object sender, EventArgs e)
        {

            int controlador;
            controlador = Buscar();
            if (controlador == 0) //se puede ingresar en la cartelera
            {
                Global.lista[1] = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex);
                MessageBox.Show("Cambios realizados con exito");
            }
            else
            {
                MessageBox.Show("No se puede colocar esta pelicula ya que se encuentra en otra funcion");
            }

        }

        private void btnElegir3_Click(object sender, EventArgs e)
        {
            int controlador;
            controlador = Buscar();
            if (controlador == 0) //se puede ingresar en la cartelera
            {
                Global.lista[2] = Global.baseFuncion.ElementAt(comboBox1.SelectedIndex);
                MessageBox.Show("Cambios realizados con exito");
            }
            else
            {
                MessageBox.Show("No se puede colocar esta pelicula ya que se encuentra en otra funcion");
            }
        }
    }
}
