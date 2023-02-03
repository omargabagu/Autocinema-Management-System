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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
            lblUsuario.Text = Global.usuarioEntrante.Nombre; //actualiza el usuario que esta en turno, en este caso un administrador
            if (Global.BaseUsuarios.Count > 1) //se bloquea ya que se interpreta que se ha comprado para una funcion y por seguridad se cierra
            {
                btnEditar.Enabled = false;
            }
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (EditarCartelera ventana = new EditarCartelera())
                ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void btnVentaBoletos_Click(object sender, EventArgs e)
        {
            using (VerVentaBoletos ventana = new VerVentaBoletos())
                ventana.ShowDialog();
        }

        private void btnVentaProductos_Click(object sender, EventArgs e)
        {
            using (VerVentaProductos ventana = new VerVentaProductos())
                ventana.ShowDialog();
        }

        private void lblAdministrador_Click(object sender, EventArgs e)
        {

        }
    }
}
