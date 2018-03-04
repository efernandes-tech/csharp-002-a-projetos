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
            Conta conta = new Conta();

            Cliente cliente = new Cliente();
            cliente.nome = "Victor";

            conta.titular = cliente;

            MessageBox.Show(conta.titular.nome); // Mostra Victor no MessageBox.
        }
    }
}
