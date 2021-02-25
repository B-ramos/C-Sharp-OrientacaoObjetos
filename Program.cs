using myBank.Funcionarios;
using myBank.Sistemas;
using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //UsarSistema();
                ContaCorrente c1 = new ContaCorrente(5,10);
                ContaCorrente c2 = new ContaCorrente(5,10);
                c1.Sacar(500);
                c1.Depositar(50);
                c2.Depositar(50);
                Console.WriteLine(c1.Saldo);
                Console.WriteLine(c2.Saldo);
                c2.Transferir(10, c1);
                Console.WriteLine(c1.Saldo);
                Console.WriteLine(c2.Saldo);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argumento com problema: {e.ParamName}");
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsulficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoInsulficienteException.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor = new Diretor("222");
            diretor.Nome = "Roberta";
            diretor.Senha = "123";
            

            GerenteDeConta gerenteDeConta = new GerenteDeConta("444");
            gerenteDeConta.Nome = "Camila";
            gerenteDeConta.Senha = "123";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123";

            sistemaInterno.Logar(diretor, "123");
            sistemaInterno.Logar(gerenteDeConta, "123");
            sistemaInterno.Logar(parceiroComercial, "123");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario designer = new Designer("111");
            designer.Nome = "Pedro";

            Funcionario diretor = new Diretor("222");
            diretor.Nome = "Roberta";

            Funcionario auxiliar = new Auxiliar("333");
            auxiliar.Nome = "Igor";

            Funcionario gerenteDeConta = new GerenteDeConta("444");
            gerenteDeConta.Nome = "Camila";

            gerenciadorBonificacao.Registar(designer);
            gerenciadorBonificacao.Registar(diretor);
            gerenciadorBonificacao.Registar(auxiliar);
            gerenciadorBonificacao.Registar(gerenteDeConta);

            Console.WriteLine($"Total de bonificações do mês: {gerenciadorBonificacao.GetTotalBonificacao()}");
        }
    }
}
