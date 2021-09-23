using System;
using Command.Invoker;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();

            pessoa.Executar('+', 14);
            Console.ReadKey();
            pessoa.Executar('-', 2);
            Console.ReadKey();

            pessoa.Desfazer(2);
            Console.ReadKey();            
        }
    }
}
