using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEncapisulamentol
{
    internal class ContaBancaria
    {
        private decimal Saldo;
        public decimal saldo
        {
            get { return saldo; }
            private set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
            }

        }

        public ContaBancaria(decimal SaldoInicial)
        { Saldo = SaldoInicial; }

        public void Depositar(decimal quantia)
        {
            if (quantia > 0)
            {
                Console.WriteLine("Deposito realizado com sucesso.Saldo atualizado" + saldo);
            }
        }

            public void Sacar(decimal quantia)
            {
                if (quantia > 0 && quantia <= Saldo)
                        {
                Saldo -= quantia;
                Console.WriteLine("saque realizado com sucesso" + Saldo);

            }

            else
            {
                Console.WriteLine("erro ao sacar ");
            }
        }
    }
}


