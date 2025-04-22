using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class Gerente
    {
        private string setor;
        
        public void definirSetor()
        {
            Console.WriteLine("Digite o nome do setor: ");
            this.setor = Console.ReadLine();

        }

        public void exibirSetor()
        {
            Console.WriteLine("Setor: {0}", this.setor);
        }
    }
}
