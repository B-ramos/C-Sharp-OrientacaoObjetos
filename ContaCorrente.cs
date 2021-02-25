using System;
using System.Collections.Generic;
using System.Text;

namespace myBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; } 
        public int Agencia { get; }  
        public static int TotalDeContasCriadas { get; private set; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)
                throw new ArgumentException("Argumento Agencia deve ser maior que zero.", nameof(numeroAgencia));
           
            if (numeroConta <= 0)
                throw new ArgumentException("Argumento Numero deve ser maior que zero.", nameof(numeroConta));           

            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalDeContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor invalido para saque", nameof(valor));

            if (_saldo < valor) 
                throw new SaldoInsulficienteException(Saldo, valor);
            
            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor < 0)
                throw new ArgumentException("Valor invalido para a transferencia", nameof(valor));

            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }
    }
}
