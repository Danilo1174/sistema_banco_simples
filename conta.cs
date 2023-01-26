using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeBanco
{
    class Conta
    {
        private int NumeroConta { get; set; }
        public string TitularConta { get; set; }
     
        private double Saldo { get; set; }

      
        public Conta(int numeroConta, string titularConta)
           { 
            NumeroConta = numeroConta;
            TitularConta = titularConta;
         

           }
       
        public Conta(int numeroConta, string titularConta, double valorInicial) : this(numeroConta, titularConta)
        {
            Saldo = valorInicial;
        }
       
     
        public void Depositar(double deposito)
        {
            Saldo += + deposito;
        }
        public void Saque(double valor)
        {
            Saldo = Saldo - 5 - valor;
        }
        public double GetSaldo()
        {
            return Saldo;
        }
       public double GetNumeroConta()
        {
            return NumeroConta;
        }

        public override string ToString()
        {
            return $" Dados da sua Conta: \n \n Titular: {TitularConta} \n Numero da Conta: {NumeroConta} \n Saldo: {Saldo} \n";
        }













    }
}
