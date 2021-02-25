using System;
using System.Collections.Generic;
using System.Text;

namespace myBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionario++;
        }

        public int GetTotalDeFuncionario()
        {
            return TotalDeFuncionario;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
        
    }
}
