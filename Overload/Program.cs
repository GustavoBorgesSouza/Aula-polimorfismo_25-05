using System;
using Overload.classes;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.Write($"Digite o nome do funcionário {i} \n");
                f.lista[i] = Console.ReadLine();
            }

            f.Mostrar();

            Console. WriteLine("Digite um indice para buscar");
            int indice = int.Parse(Console.ReadLine());
            f.Mostrar(indice);

            Console.WriteLine("Digite um nome para buscar");
            string busca = Console.ReadLine();
            f.Mostrar(busca);

        }
    }
}
