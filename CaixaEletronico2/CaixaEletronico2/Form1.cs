using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            guilherme.numero = 1;
            guilherme.titular = "Guilherme";
            guilherme.saldo = 1500.0;

            Conta mauricio = new Conta();
            mauricio.numero = 2;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 2500.0;

            guilherme.Transfere(200.0, mauricio);

            MessageBox.Show("Saldo Guilherme: " + guilherme.saldo);
            MessageBox.Show("Saldo Maurício: " + mauricio.saldo);
        }
    }
}
