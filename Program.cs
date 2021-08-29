using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, eu me chamo Murillo!");
            Console.ReadLine();

            Console.WriteLine("Agora me diga, qual o seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine($"É um prazer conhece-lo {Nome}");
        }
    }
}
