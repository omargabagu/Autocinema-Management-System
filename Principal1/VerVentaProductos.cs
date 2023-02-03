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
    public partial class VerVentaProductos : Form
    {
        int contRefrescosMedianos;
        int contRefrescosGrandes;
        int contRefrescosChicos;
        int contPalomitasGrandes;
        int contPalomitasMedianas;
        int contPalomitasChicas;
        int contNachos;
        int contHotDogs;
        int contChocolates;
        int contICEE;


        public VerVentaProductos()
        {
            InitializeComponent();
            ConfiguracionInicial();
            Conteo();
            Actualizar();
        }


        private void Actualizar()
        {
            lblCantChocolates.Text = contChocolates.ToString();
            lblCantHotDogs.Text = contHotDogs.ToString();
            lblCantICEE.Text = contICEE.ToString();
            lblCantNachos.Text = contNachos.ToString();
            lblCantPC.Text = contPalomitasChicas.ToString();
            lblCantPG.Text = contPalomitasGrandes.ToString();
            lblCantPM.Text = contPalomitasMedianas.ToString();
            lblCantRC.Text = contRefrescosChicos.ToString();
            lblCantRG.Text = contRefrescosGrandes.ToString();
            lblCantRM.Text = contRefrescosMedianos.ToString();
        }


        private void ConfiguracionInicial()
        {
            lblCantChocolates.Text = "0";
            lblCantNachos.Text = "0";
            lblCantICEE.Text = "0";
            lblCantHotDogs.Text = "0";
            lblCantRG.Text = "0";
            lblCantRM.Text = "0";
            lblCantRC.Text = "0";
            lblCantPM.Text = "0";
            lblCantPG.Text = "0";
            lblCantPC.Text = "0";
        }

        //acude a la base de usuarios y cuenta los complementos que cada uno almacena
        private void Conteo()
        {
            foreach(Usuario elem in Global.BaseUsuarios)
            {
                foreach(Complementos elemComp in elem.ListaComplementos)
                {
                    if(elemComp.Id == "FS001")
                    {
                        contRefrescosGrandes++;
                    }
                    if (elemComp.Id == "FS002")
                    {
                        contHotDogs++;
                    }
                    if (elemComp.Id == "FS003")
                    {
                        contPalomitasGrandes++;
                    }
                    if (elemComp.Id == "FS004")
                    {
                        contICEE++;
                    }
                    if (elemComp.Id == "FS005")
                    {
                        contNachos++;
                    }
                    if (elemComp.Id == "FS006")
                    {
                        contRefrescosMedianos++;
                    }
                    if (elemComp.Id == "FS007")
                    {
                        contPalomitasMedianas++;
                    }
                    if (elemComp.Id == "FS008")
                    {
                        contRefrescosChicos++;
                    }
                    if (elemComp.Id == "FS009")
                    {
                        contPalomitasChicas++;
                    }
                    if (elemComp.Id == "FS010")
                    {
                        contChocolates++;
                    }

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCantRG_Click(object sender, EventArgs e)
        {

        }

        private void VerVentaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
