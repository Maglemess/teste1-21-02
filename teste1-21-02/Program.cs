using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1_21_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            string cidade;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua Cidade");
            cidade = Console.ReadLine();



            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Cidade: {0}", cidade);
            // Console.WriteLine("nome: {0} \n Idade: {1} anos \n Cidade: {2}", nome, idade, cidade);
        }
    }
}
