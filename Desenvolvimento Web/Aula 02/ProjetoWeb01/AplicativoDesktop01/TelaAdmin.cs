using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {
        private static readonly HttpClient clienteHttp = new();
        private const string urlApiAdmin = "http://localhost:5069/api/usuarios/Admin";
        public TelaAdmin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TelaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
