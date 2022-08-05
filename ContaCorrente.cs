using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular; // namespace referente a classe Cliente

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular{ get; set; }
        private string conta;
        private int numeroAgencia;
        public string NomeAgencia{ get; set; }  
        
        private double saldo;

        public ContaCorrente(Cliente titular, string conta, int numeroAgencia, string nomeAgencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            NumeroAgencia = numeroAgencia;
            NomeAgencia = nomeAgencia;
            Saldo = saldo;
            Conta = conta;
            NumeroAgencia = numeroAgencia;
            Saldo = saldo;
            TotalDeContasCriadas++;
        }

        public ContaCorrente()
        {
            //Sobrecarga de metodo construtor
            TotalDeContasCriadas++;
        }
        public ContaCorrente(string conta, int numeroAgencia)
        {
            this.Conta = conta;
            this.NumeroAgencia = numeroAgencia;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valorSacar)
        {
            if(Saldo < valorSacar || valorSacar <=0)
            {
                
                Console.WriteLine("Erro na saque");
                return false;
            } 
            else
            {
                Saldo-=valorSacar;
                return true;
            }
           
        }

        public bool Depositar(double valorDepositar)
        {
            if(valorDepositar < 0)
            {
                return false;
            }
            else
            {
                Saldo += valorDepositar;
                return true;
            }

            
        }


        public bool Transferir(double valorTransferir, ContaCorrente contaDestino)
        {
            if(Saldo < valorTransferir || valorTransferir <= 0 )
            {
                Console.WriteLine("Erro na transferencia");
                return false;
            }
            else
            {
                Saldo-=valorTransferir;
                contaDestino.Saldo+=valorTransferir;
                return true;
            }
        }

        public void MostrarPerfilConta()
        {   
            Console.WriteLine(
            @"Nome titular: " + this.Titular.Nome +
            " CPF titular: " + this.Titular.Cpf +
            " Profissao titular: " + this.Titular.Profissao +
            " Conta: " + this.Conta + 
            " Saldo: " + this.Saldo + 
            " Numero da agencia: " + this.NumeroAgencia + 
            " Nome da agencia: " + this.NomeAgencia);   
        }

        public String Conta
        {
            get
            {
                return this.conta;
            }

            set
          {
                if(value != null)
                {
                    this.conta = value;
                }
                else
                {
                    return;
                }

                 
           }
        }

        public int NumeroAgencia
        {
            get
            {
                return this.numeroAgencia;
            }

            set
            {
                if (value<=0)
                {
                    return ;
                }
                else
                {
                    this.numeroAgencia = value;
                }
               
            }
        }


        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;  
                }
            }
        }

        public static int TotalDeContasCriadas { get; set; }
    }
}