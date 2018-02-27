using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta;
            numeroDaConta = 1;

            double saldo = 100.0;
            double saque = 10.0;
            double saldoAposSaque = saldo - saque;

            MessageBox.Show("O saldo da conta " + numeroDaConta + " é " + saldoAposSaque);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100.0;

            MessageBox.Show(c.titular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim José";
            umaConta.saldo = 1500.0;
            umaConta.cpf = "111.222.333-44";
            umaConta.agencia = 23;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva Xavier";
            outraConta.saldo = 2500.0;
            outraConta.cpf = "444.333.222-11";
            outraConta.agencia = 34;

            MessageBox.Show(umaConta.titular + " - " + umaConta.cpf + " - " + umaConta.agencia);
            MessageBox.Show(outraConta.titular + " - " + outraConta.cpf + " - " + outraConta.agencia);
        }
    }
}
