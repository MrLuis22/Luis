using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuevaraLuis
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Cliente Cliente = new Cliente();
            Cliente.Show();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Carro Carro = new Carro();
            Carro.Show();
        }

        private void btnParqueo_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Parqueo Parqueo = new Parqueo();
            Parqueo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Principal.Close();
        }
    }
}
