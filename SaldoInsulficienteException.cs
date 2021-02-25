using System;
using System.Collections.Generic;
using System.Text;

namespace myBank
{
    public class SaldoInsulficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorDoSaque { get; }
        public SaldoInsulficienteException() { }

        public SaldoInsulficienteException(double saldo, double valorDoSaque) 
            : this($"Tentativa de saque de valor R${valorDoSaque} em conta com valor de R${saldo}")
        {
            Saldo = saldo;
            ValorDoSaque = valorDoSaque;
        }

        public SaldoInsulficienteException(string mensagem) : base(mensagem) { }
    }
}
