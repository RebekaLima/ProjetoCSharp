using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class Pessoa
    {
        protected string nome;
        protected string email;

        public virtual void cadastrarPessoa()
        {
            Console.WriteLine("Digite o seu nome: ");
            this.nome = Console.ReadLine();

            Console.WriteLine("Digite o seu e-mail: ");
            this.email = Console.ReadLine();
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome:{0}", this.nome);
            Console.WriteLine("E-mail:{0}", this.email);
        }
    }
}
