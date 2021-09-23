using System;

namespace Command.Receiver
{
    public class Televisao
    {
        private int _valorAtual;

        public void Operacao(char acao, int valor)
        {
            switch (acao)
            {
                case '+': _valorAtual += valor; break;
                case '-': _valorAtual -= valor; break;                
            }
            Console.WriteLine("(Volume {1} {2}) ---> Volume Atual = {0,3}", _valorAtual, acao, valor);
        }
    }
}
