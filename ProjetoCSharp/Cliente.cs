using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class Cliente
    {
        protected int Id;

        public void Cadastrar ()
        {
            Console.WriteLine("Digite o ID de cadastro: ");
            this.Id = int.Parse(Console.ReadLine());
        }
        public int Exibir()
        {
            return Id;
        }
    }
}
