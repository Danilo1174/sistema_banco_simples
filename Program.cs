using System;


namespace AtividadeBanco
{
    class Program
    {
        static void Main(string[] args)

        {
            int op;

            do
            {
                Console.WriteLine("1. Abrir Conta");
                Console.WriteLine("2. Sair");
                op = int.Parse(Console.ReadLine());


                if (op == 1)
                {


                    Console.WriteLine("Insira seu nome Completo: ");
                    string titularConta = Console.ReadLine();
                    Console.WriteLine("Informe o número da Conta: ");
                    int numeroConta = int.Parse(Console.ReadLine());
                    Conta novaconta = new Conta(numeroConta, titularConta);
                    Console.WriteLine("Deseja Depositar Algum Valor inicialmente? ");
                    Console.WriteLine("1.Sim ou 2.Nao");
                    int valorop = int.Parse(Console.ReadLine());
                    if (valorop == 1)
                    {
                        Console.WriteLine("insira o Valor a ser Depositado inicial: ");
                        double valorInicial = double.Parse(Console.ReadLine());
                        novaconta = new Conta(numeroConta, titularConta, valorInicial);
                        Console.WriteLine(novaconta.ToString());

                        Console.WriteLine(" deseja realizar alguma outra operacao? ");
                        Console.WriteLine("1.Sim ou 2.Nao");

                        int opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            Console.WriteLine("Qual operacão deseja realizar?  ");
                            Console.WriteLine("1. Saque   2. Deposito  ");
                            int escolha = int.Parse(Console.ReadLine());
                            if (escolha == 1)
                            {
                                Console.WriteLine("qual valor deseja sacar");
                                double valor = double.Parse(Console.ReadLine());
                                novaconta.Saque(valor);
                                Console.WriteLine(novaconta.ToString());
                            }
                            else if (escolha == 2)
                            {
                                Console.WriteLine("Insira o valor a ser depositado: ");
                                double deposito = double.Parse(Console.ReadLine());
                                novaconta.Depositar(deposito);
                                Console.WriteLine(novaconta.ToString());
                            }
                        }
                        else if (opcao == 2)
                        {
                            Console.WriteLine(novaconta.ToString());
                        }
                    }
                    else if (valorop == 2)
                    {
                        Console.WriteLine(novaconta.ToString());
                    }



                }
                else if (op == 2)
                {
                    Console.WriteLine("Obrigado por ultilizar nosso sistema");
                   
                 }


            } while (op <= 1);
        }
    }
}
