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
    public partial class ComprarBoletos : Form
    {
        public int seleccion =-1; //ayudara a indicar el indice de la funcion donde se desea colocar el usuario
        public int posP=-1; //indica el indice de la pelicula seleccionada
        public ComprarBoletos()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ComprarBoletos_Load(object sender, EventArgs e)
        {

        }


        //requerimientos necesarios para que se vea bien el form
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
            actualizar1();

            if(Global.usuarioEntrante.Compra == true)
            {
                MessageBox.Show("Solo se permite un boleto por usuario, porfavor da clicl en salir");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                bnt5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btnContinuar.Enabled = false;

            }


        }

        //actualiza la informacion de la pelicula seleccionada asi como la imagen del pictureBox2
        public void actualizarPelicula()
        {
            lblTitulo.Text = Global.lista[comboBox1.SelectedIndex].Nombre;
            lblHorario.Text = "Hora de inicio: " + Global.lista[comboBox1.SelectedIndex].Horario;
            lblDirector.Text = "Director: " + Global.lista[comboBox1.SelectedIndex].Director;
            lblDuracion.Text = "Duración: " + Global.lista[comboBox1.SelectedIndex].Duracion;
            lblClasificacion.Text = "Clasificación: " + Global.lista[comboBox1.SelectedIndex].Clasificacion;
            lblResegna.Text = "Reseña: " + Global.lista[comboBox1.SelectedIndex].Resena;
            pictureBox2.Image = Global.lista[comboBox1.SelectedIndex].imagen;
            Global.usuarioEntrante.IdPelicula = comboBox1.SelectedIndex;
        }

        //cada que se seleccione en el comboBox se tiene que actualizar sus campos
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPelicula();
        }


        //actuzalizamos el estado de las funciones
        public void actualizar1()
        {
            if (seleccion != -1)
            {
                lblLugar.Text = "Lugar " + (seleccion+1) + " seleccionado.";
            }
            else
            {
                lblLugar.Text = "Seleccionar lugar...";
            }
            if (seleccion != -1)
            {
                btnContinuar.Enabled = true;

            }
            else
            {
                btnContinuar.Enabled = false;
            }
                

        }


        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioCliente inicioCliente = new InicioCliente();
            inicioCliente.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
 
            seleccion = 0;

            try
            {
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {

                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch(IndexOutOfRangeException i)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        
        private void btn2_Click_1(object sender, EventArgs e)
        {

            try
            {
                seleccion = 1;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch(IndexOutOfRangeException i)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 2;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch(IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 3;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }




        }

        private void bnt5_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 4;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }




        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion = 5;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion = 6;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion = 7;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 8;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }



        private void btn10_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion = 9;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 10;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 11;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }


        }

        private void btn13_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 12;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }


        }

        private void btn14_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 13;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }



        private void btn15_Click(object sender, EventArgs e)
        {

            try
            {
                seleccion = 14;
                if (Global.lista[comboBox1.SelectedIndex].Lugar[seleccion] == true) //verifica si se encuentra disponible
                {
                    posP = comboBox1.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Lo sentimos el asiento ya se encuentra ocupado");
                    seleccion = -1;
                }
                actualizar1();
            }

            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Primero tienes que elegir la pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            using (IngresaAutomovil ventana = new IngresaAutomovil(seleccion,posP))
                ventana.ShowDialog();
            using (VentaProductos ventana = new VentaProductos())
                ventana.ShowDialog();
            using (TarjetaCredito ventana = new TarjetaCredito())
                ventana.ShowDialog();

            ConfiguracionInicial();

        }
    }
}
