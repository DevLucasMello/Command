using System;
using Command.Receiver;

namespace Command.Command
{
    public class TelevisaoCommand : Commander
    {
        private char _acao;
        private int _valor;
        private readonly Televisao _televisao;

        public TelevisaoCommand(Televisao televisao, char acao, int valor)
        {
            _televisao = televisao;
            _acao = acao;
            _valor = valor;
        }

        public char Acao
        {
            set => _acao = value;
        }

        public int Valor
        {
            set => _valor = value;
        }

        public override void Executar()
        {
            _televisao.Operacao(_acao, _valor);
        }

        public override void Desfazer()
        {
            _televisao.Operacao(Desfazer(_acao), _valor);
        }

        private static char Desfazer(char acao)
        {
            switch (acao)
            {
                case '+': return '-';
                case '-': return '+';                
                default: throw new ArgumentException("Ação desconhecida");
            }
        }
    }
}
