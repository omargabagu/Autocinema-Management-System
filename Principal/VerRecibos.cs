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
    public partial class VerRecibos : Form
    {
        public VerRecibos()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {
            float totalComp;

            lblNomb1.Text = "";
            lblNomb2.Text = "";
            lblNomb3.Text = "";
            lblNomb4.Text = "";
            lblNomb5.Text = "";
            lblNomb6.Text = "";
            lblNomb7.Text = "";
            lblPrecio1.Text = "";
            lblPrecio2.Text = "";
            lblPrecio3.Text = "";
            lblPrecio4.Text = "";
            lblPrecio5.Text = "";
            lblPrecio6.Text = "";
            lblPrecio7.Text = "";

            if (Global.usuarioEntrante.ListaComplementos.Count != 0)
            {


                foreach (Complementos elem in Global.usuarioEntrante.ListaComplementos)
                {
                    if(lblNomb1.Text == "")
                    {
                        lblNomb1.Text = elem.Nombre;
                        lblPrecio1.Text = elem.Costo.ToString();
                    }
                    else if(lblNomb2.Text == "")
                    {
                        lblNomb2.Text = elem.Nombre;
                        lblPrecio2.Text = elem.Costo.ToString();
                    }
                    else if(lblNomb3.Text == "")
                    {
                        lblNomb3.Text = elem.Nombre;
                        lblPrecio3.Text = elem.Costo.ToString();
                    }
                    else if(lblNomb4.Text == "")
                    {
                        lblNomb4.Text = elem.Nombre;
                        lblPrecio4.Text = elem.Costo.ToString();
                    }
                    else if(lblNomb5.Text == "")
                    {
                        lblNomb5.Text = elem.Nombre;
                        lblPrecio5.Text = elem.Costo.ToString();
                    }

                    else if(lblNomb6.Text == "")
                    {
                        lblNomb6.Text = elem.Nombre;
                        lblPrecio6.Text = elem.Costo.ToString();
                    }

                    else if (lblNomb7.Text == "")
                    {
                        lblNomb7.Text = elem.Nombre;
                        lblPrecio7.Text = elem.Costo.ToString();
                    }
                }

                totalComp = Global.usuarioEntrante.Total - Global.usuarioEntrante.CostoBoleto;
                lblTotal.Text = "Total: " + totalComp.ToString();
                
            }
            else
            {
                MessageBox.Show("No tienes ninguna compra de complementos");
            }

        }

        private void VerRecibos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
