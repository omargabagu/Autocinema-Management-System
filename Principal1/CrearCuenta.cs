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
    public partial class CrearCuenta : Form
    {
        int estado;

        public CrearCuenta(int entero)
        {
            InitializeComponent();
            estado = entero;
            ConfiguracionInicial();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        //verifica si todos los campos tienen almenos 4 caracteres
        //en caso del telefono se solicita que sea de exactamente 10 caracteres
        private void actualizar()
        {
            if(txtNombre.Text.Length>2 && txtAM.Text.Length >3  && txtAP.Text.Length >3  && txtContrasegna.Text.Length>3 && txtCorreo.Text.Length>3 &&txtDireccion.Text.Length>3 && txtNombre.Text.Length>3 && txtTelefono.Text.Length == 10)
            {
                btnCrear.Enabled = true;
            }
            else
            {
                btnCrear.Enabled = false;
            }

        }

        //incializa todos los textBox sin ninguna cadena
        private void ConfiguracionInicial()
        {
            if(estado == 0) //estado de creacion de cuenta
            {
                lblCreacionCuenta.Text = "Creacion de cuenta: ";
            }
            else if(estado == 1) //estado de edicion de cuenta
            {
                lblCreacionCuenta.Text = "Configuracion de cuenta: ";
            }
            txtNombre.Text = "";
            txtAM.Text = "";
            txtAP.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtContrasegna.Text = "";
            btnCrear.Enabled = false;
            
        }


        //busca en la base de Usuarios la contraseña y el correo ya existen
        //en caso de que existan el programa retorna un true 
        //en caso contrario retorna false
        private bool Buscar()
        {
            foreach (Usuario elem in Global.BaseUsuarios)
            {
                if (elem.Correo == txtCorreo.Text && elem.Contrasegna == txtContrasegna.Text)
                {
                    return true;
                }
            }
            return false;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtAP_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtAM_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtContrasegna_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if(estado == 0) //estado de creacion de cuenta
            {
                //en caso de que la cuenta exista
                if (Buscar())
                {
                    MessageBox.Show("El correo electronico ya se encuentra registrado en el sistema, trata de iniciar sesion");
                    ConfiguracionInicial();
                }
                //en caso de que la cuenta no exista
                else
                {
                    Global.BaseUsuarios.Add(new Usuario(txtNombre.Text, txtAM.Text, txtAP.Text, txtCorreo.Text, txtContrasegna.Text, txtTelefono.Text, txtDireccion.Text, Global.cantUsuarios));
                    Global.cantUsuarios++;
                    MessageBox.Show("Cuenta Creada con exito");
                    this.Close();
                }
            }
            else if( estado == 1)
            {
                Usuario modificar = new Usuario (txtNombre.Text, txtAM.Text, txtAP.Text, txtCorreo.Text, txtContrasegna.Text, txtTelefono.Text, txtDireccion.Text, Global.usuarioEntrante.Id);
                Global.BaseUsuarios.Insert(Global.usuarioEntrante.Id, modificar);
                Global.usuarioEntrante = modificar;
                MessageBox.Show("Cuenta modificada con exito");
                this.Close();

            }

        }
    }
}
