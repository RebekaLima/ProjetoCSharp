using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class Funcionario
    {
        private double salario;
        private int registo;
        public Pessoa[] dependentes = new Pessoa[5];

        public void definirSalario()
        {
            Console.WriteLine("Digite o salário: ");
            this.salario = double.Parse(Console.ReadLine());
        }

        public void exibirSalario()
        {
            Console.WriteLine("Salário: {0}", this.salario);
        }

        public void desconto()
        {

        }

        public void bonus()
        {

        }

        public void cadastrarRegistro()
        {
            Console.WriteLine("Digite o número do registro: ");
            this.registo = int.Parse(Console.ReadLine());
        }

        public void consultarRegistro()
        {
            Console.WriteLine("Digite o número do registro: ");
            


        }

        public void adicionarDependentes()
        {
            Console.WriteLine("Digite o nome do dependente: ");
            string dependente = Console.ReadLine();
            this.dependentes[0] = new Pessoa();

            Console.WriteLine("Deseja adicionar mais dependentes?");
            Console.WriteLine("Digite 1 para continuar ou 2 para finalizar");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                for (int i = 1; i  < this.dependentes.Length; i++ )
                { 
                    Console.WriteLine("Digite o nome do próximo dependente: ");
                    string dados = Console.ReadLine();
                    this.dependentes[i] = new Pessoa();
                }

            } else if (resposta == 2) {
                Console.WriteLine("Dependente adicionado com sucesso!");
            }
        }



    }
}
