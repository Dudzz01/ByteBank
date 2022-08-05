using ByteBank;
using ByteBank.Titular;
public class main
{
    static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.Titular = new Cliente();
        conta1.Titular.Nome = "Jose";
        conta1.Titular.Cpf = "14059140236";
        conta1.Titular.Profissao = "Carpinteiro";
        conta1.Conta = "10203-x";
        conta1.NumeroAgencia = 12;
        conta1.NomeAgencia = "Agencia central";
        conta1.Saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.Titular = new Cliente();
        conta2.Titular.Nome = "Maria";
        conta2.Titular.Cpf = "14123180736";
        conta2.Titular.Profissao = "Jogadora de tenis";
        conta2.Conta = "10206-x";
        conta2.NumeroAgencia = 32;
        conta2.NomeAgencia = "Agencia central";
        conta2.Saldo = 100;

        Cliente cliente3 = new Cliente("Eduardo Mury Assafin", "12050148775", "Programador .Net C#");
        
        ContaCorrente conta3 = new ContaCorrente(cliente3, "102200-x",50,"Agencia leste",100);
        conta1.MostrarPerfilConta();
        conta2.MostrarPerfilConta();
        conta3.MostrarPerfilConta();
        

        Console.WriteLine("Total de contas criadas: "+ContaCorrente.TotalDeContasCriadas);

        Console.ReadKey();
    }
}
