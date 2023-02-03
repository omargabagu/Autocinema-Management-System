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
    public partial class VerVentaBoletos : Form
    {
        public VerVentaBoletos()
        {
            InitializeComponent();
            CargaInicial();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //coloca los colores de los acientos en blanco
        private void CargaInicial()
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.BackColor = Color.White;
            btn12.BackColor = Color.White;
            btn13.BackColor = Color.White;
            btn14.BackColor = Color.White;
            btn15.BackColor = Color.White;
        }


        private void ActualizarBotones(int pos)
        {
            if(pos == 0)
            {
                btn1.BackColor = Color.Aqua;
            }
            if (pos == 1)
            {
                btn2.BackColor = Color.Aqua;
            }
            if (pos == 2)
            {
                btn3.BackColor = Color.Aqua;
            }
            if (pos == 3)
            {
                btn4.BackColor = Color.Aqua;
            }
            if (pos == 4)
            {
                btn5.BackColor = Color.Aqua;
            }
            if (pos == 5)
            {
                btn6.BackColor = Color.Aqua;
            }
            if (pos == 6)
            {
                btn7.BackColor = Color.Aqua;
            }
            if (pos == 7)
            {
                btn8.BackColor = Color.Aqua;
            }
            if (pos == 8)
            {
                btn9.BackColor = Color.Aqua;
            }
            if (pos == 9)
            {
                btn10.BackColor = Color.Aqua;
            }
            if (pos == 10)
            {
                btn11.BackColor = Color.Aqua;
            }
            if (pos == 11)
            {
                btn12.BackColor = Color.Aqua;
            }
            if (pos == 12)
            {
                btn13.BackColor = Color.Aqua;
            }
            if (pos == 13)
            {
                btn14.BackColor = Color.Aqua;
            }
            if (pos == 14)
            {
                btn15.BackColor = Color.Aqua;
            }

        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            CargaInicial();
            for(int i = 0; i < 15; i++)
            {
                if (Global.lista[0].Lugar[i] == false)
                {
                    ActualizarBotones(i);
                }
            }
            
        }

        private void btnFuncion2_Click(object sender, EventArgs e)
        {
            CargaInicial();
            for (int i = 0; i < 15; i++)
            {
                if (Global.lista[1].Lugar[i] == false)
                {
                    ActualizarBotones(i);
                }
            }
        }

        private void btnFuncion3_Click(object sender, EventArgs e)
        {
            CargaInicial();
            for (int i = 0; i < 15; i++)
            {
                if (Global.lista[2].Lugar[i] == false)
                {
                    ActualizarBotones(i);
                }
            }
        }

        private void VerVentaBoletos_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
