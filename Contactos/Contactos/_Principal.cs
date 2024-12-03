using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos
{
    public partial class _Principal : Form
    {
        public _Principal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new BuscarContacto().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la agenda de contactos. \nPor favor, presiona cualquier tecla para continuar", "Agenda de Contactos", MessageBoxButtons.OK);
        }

        private void _Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
