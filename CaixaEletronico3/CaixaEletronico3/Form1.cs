using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            victor.nome = "victor";

            Conta umaConta = new Conta();
            umaConta.cliente = victor;

            umaConta.cliente.rg = "12345678-9";

            MessageBox.Show(umaConta.cliente.nome);
        }
    }
}
