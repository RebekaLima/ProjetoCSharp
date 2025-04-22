using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class ClienteVip
    {
        private double desconto;
        private double cashback;

        public double calcularDesconto(double valorInicial, double valorComDesconto)
        {
            valorComDesconto = valorInicial * (this.desconto / 100);
            return valorComDesconto;
        }

        public void exibirDesconto()
        {
            Console.WriteLine("Você receberá um cashback no valor de:{0}", this.desconto);
        }

        public double calcularCashback(double valorCompra, double valorComCashback)
        {
            valorComCashback = valorCompra * (this.cashback / 100);
            return valorComCashback;
        }

        public void exibirCashback()
        {
            Console.WriteLine("Você receberá um cashback no valor de:{0}", this.cashback);
        }
            
        }
}
