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

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new Conta();
            contaGuilherme.numero = 1;
            contaGuilherme.saldo = 1500.0;

            Cliente clienteGuilherme = new Cliente();
            clienteGuilherme.nome = "Guilherme";
            clienteGuilherme.idade = 18;

            contaGuilherme.titular = clienteGuilherme;

            bool sacou = contaGuilherme.Saca(300.0);//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            }
        }
    }
}
