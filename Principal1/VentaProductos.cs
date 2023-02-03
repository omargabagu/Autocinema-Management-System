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
    public partial class VentaProductos : Form
    {
        public VentaProductos()
        {
            InitializeComponent();
            CargaInicial();
        }

        public void CargaInicial()
        {
            txtCantPalomitas.Text = "0";
            txtCantChocolates.Text = "0";
            txtCantHotDog.Text = "0";
            txtCantIcee.Text = "0";
            txtCantNachos.Text = "0";
            txtCantRefresco.Text = "0";
        }



       

        private void CalculoPagar()
        {
            //calculo a pagar de las palomitas
            if(cBxPalomitas.Text == "Grandes")
            {
                if ( Convert.ToInt32 (txtCantPalomitas.Text)>0)
                {
                   
                    for(int i=0; i< Convert.ToInt32(txtCantPalomitas.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 70;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(2));
                    }
                    
                }
               
            }

            else if (cBxPalomitas.Text == "Medianas")
            {
                if (Convert.ToInt32(txtCantPalomitas.Text) > 0)
                {
                   
                    for (int i = 0; i < Convert.ToInt32(txtCantPalomitas.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 58;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(6));
                    }
                        

                }
                    
            }
            else if (cBxPalomitas.Text == "Chicas")
            {
                if (Convert.ToInt32(txtCantPalomitas.Text) > 0)
                {
                    
                    for (int i = 0; i < Convert.ToInt32(txtCantPalomitas.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 46;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(8));
                    }  
                }
                    
            }



            //de los refrescos


            if (cBxRefresco.Text == "Grande")
            {
                if (Convert.ToInt32(txtCantRefresco.Text) > 0)
                {
                    for(int i=0; i<Convert.ToInt32(txtCantRefresco.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 45;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(0));
                    }
                }
            }

            else if (cBxRefresco.Text == "Mediano")
            {
                if (Convert.ToInt32(txtCantRefresco.Text) > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(txtCantRefresco.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 38;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(5));
                    }
                }
            }
            else if (cBxRefresco.Text == "Chico")
            {
                if (Convert.ToInt32(txtCantRefresco.Text) > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(txtCantRefresco.Text); i++)
                    {
                        Global.usuarioEntrante.Total += 32;
                        Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(7));
                    }
                        
                }
            }


            //de los hog dogs

            for(int i = 0; i < Convert.ToInt32(txtCantHotDog.Text); i++)
            {
                Global.usuarioEntrante.Total += 40;
                Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(1));
            }



            //de los nachos

            for (int i = 0; i < Convert.ToInt32(txtCantNachos.Text); i++)
            {
                Global.usuarioEntrante.Total += 70;
                Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(4));
            }


            //del Icee
            for (int i = 0; i < Convert.ToInt32(txtCantIcee.Text); i++)
            {
                Global.usuarioEntrante.Total += 55;
                Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(3));
            }
               

            //de los chocolates
            for (int i = 0; i < Convert.ToInt32(txtCantChocolates.Text); i++)
            {
                Global.usuarioEntrante.Total += 34;
                Global.usuarioEntrante.ListaComplementos.Add(Global.baseComplementos.ElementAt(9));
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculoPagar();
            MessageBox.Show("El total a pagar es: " + Global.usuarioEntrante.Total);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
