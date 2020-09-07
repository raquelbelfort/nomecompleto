using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Olá, usuário! Por favor, escreva seu primeiro nome: ");
            string nomeusuario = Console.ReadLine();
            Console.WriteLine("Agora, escreva seu sobrenome:");
            string sobrenomeusuario = Console.ReadLine();
            Console.Write("Seu nome completo é: " );
            Console.WriteLine(nomeusuario + " " + sobrenomeusuario);
            Console.Write("Seu nome de catálogo é: ");
            Console.WriteLine(sobrenomeusuario.ToUpper() + ", " + nomeusuario);
        }
    }
}
