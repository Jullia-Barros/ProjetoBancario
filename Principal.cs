using System;
 using System.Collections Generic;
 using System.Linq;
 using System.text;
 using System.Threading.Tasks;

namespace ProjetoBancario
{
    internal class Principal
    {
        static void main (String[] args)
        {
            Conta conta=new Conta();

            int op=0;

            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção desejada:\n1-Depositar\n2- Sacar\n3-Transferir\n4-Consultar Saldo\n 0-Sair");
                op= int.Parse (Console.ReadLinee());

                switch (op)
                {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine ("Informe o valor de depósito");
                    double valor= Parse (Console.ReadLine());

                    conta.Depositar(valor);
                    Console.WriteLine("Depósito efetuado com sucesso!");
                    break;
                case 2:
                      Console.WriteLine("Informe o valor do saque");
                      valor=double.Parse (Console.ReadLine());

                    if (Conta.Sacar(valor))
                    {
                        Console.WriteLine("Saque efetuado com sucesso!");
        
                    }else
                    {
                        Console.WriteLine("Saldo Insuficiente!");
                    }
                    break;
                case 3:
                     Console.WriteLine("Infome o valor da Transferencia");
                     valor=double.Parse (Console.ReadLine());

                     Conta destino= new Conta ();
                     Console.WriteLine("Informe o número da conta de destino");

                     destino.numero = int.Parse(Console.ReadLine());

                     conta.Transferir (valor, destino);
                     break;
                case 4:
                     Console.WriteLine("Saldo atual:" +conta.ConsultarSaldo());
                     break;

                     default:
                       Console.WriteLine("Opção Inválida!");
                       break;
            }
                 Console.Readkey();
            }while (op != 0);
        }
    }
}