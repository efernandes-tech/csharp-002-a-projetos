using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico3
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
            {
                this.saldo += valorASerDepositado;
            }
        }

        public void Saca(double valorASerSacado)
        {
            if (this.saldo >= valorASerSacado && valorASerSacado > 0)
            {
                this.saldo -= valorASerSacado;
            }
        }
    }
}
