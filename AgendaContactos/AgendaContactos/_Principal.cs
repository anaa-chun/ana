using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class _Principal : Form
    {
        public _Principal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {}

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la agenda de contacto", "Despedida", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new buscar().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new insertar().Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new actualizar().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new eliminar().Show();
        }
    }
}
