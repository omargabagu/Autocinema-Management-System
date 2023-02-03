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
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.portada.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            using (Form1 form = new Form1())
            form.ShowDialog();
        }
    }
}
