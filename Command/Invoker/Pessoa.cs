using System;
using System.Collections.Generic;
using Command.Command;
using Command.Receiver;

namespace Command.Invoker
{
    public class Pessoa
    {
        // Iniciando
        private readonly Televisao _televisao = new Televisao();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Executar(char acao, int valor)
        {
            Commander command = new TelevisaoCommand(_televisao, acao, valor);
            command.Executar();

            _commands.Add(command);
            _total++;
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine("\n---- Desfazendo {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}
