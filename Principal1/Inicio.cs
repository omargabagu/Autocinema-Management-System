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
    public partial class Inicio : Form
    {

        

        public Inicio()
        {
            
            InitializeComponent();
            InstanciarAdmin();
            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.portada.Show();
        }

        private void actualizar()
        {
            if(txtContrasegna.Text.Length >3  && txtCorreo.Text.Length > 3)
            {
                btnInicio.Enabled = true;
            }
            else
            {
                btnInicio.Enabled = false;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtContrasegna_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void lblRegistrate_Click(object sender, EventArgs e)
        {
            using (CrearCuenta ventana = new CrearCuenta(0))
                ventana.ShowDialog();
           
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            int pos;

            pos = Buscar();
            //en caso de que el usuario se haya encontrado en la base
            if (pos!=-1)
            {
                if (Global.BaseUsuarios.ElementAt(pos).Correo == "FotoAdmon" && Global.BaseUsuarios.ElementAt(pos).Contrasegna == "F3C&2116fi_8e15ñ")
                {
                    this.Close();
                    Global.usuarioEntrante = Global.BaseUsuarios.ElementAt(0);
                    Global.usuarioEntrante.Admin = true;
                    InicioAdmin inicioAdmin = new InicioAdmin();
                    inicioAdmin.Show();
                }
                else
                {
                    this.Close();
                    Global.usuarioEntrante = Global.BaseUsuarios.ElementAt(pos);
                    InicioCliente inicioCliente = new InicioCliente();
                    inicioCliente.Show();
                }
            }
            else //en caso de que el usuario no este registrado
            {
                MessageBox.Show("El usuario no se encuentra registrado, porfavor crea una cuenta");
            }

        }

        //busca en la base de Usuarios la contraseña y el correo 
        //en caso de que existan el programa retorna la posicion de la lista donde se encuentran
        //en caso contrario retorna -1
        private int Buscar()
        {
            int cont=0;

            foreach(Usuario elem in Global.BaseUsuarios)
            {
                if (elem.Correo == txtCorreo.Text && elem.Contrasegna == txtContrasegna.Text)
                {
                    return cont;
                }
                cont++;
            }
            return -1;
        }

        //para crear un administrador
        private void InstanciarAdmin()
        {
            Global.BaseUsuarios.Add(new Usuario("jesus", "camacho", "alfaro", "FotoAdmon", "F3C&2116fi_8e15ñ", "1111111111", "facultad ing",Global.cantUsuarios));
            Global.cantUsuarios++;
           
        }
    }
}
