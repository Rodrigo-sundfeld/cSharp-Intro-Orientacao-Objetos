using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - C# - parte 2 - Introdução a O.O.");
            Console.WriteLine();

            ContaCorrente contaDoRodrigo = new ContaCorrente();

            contaDoRodrigo.titular = "Rodrigo Sundfeld";
            contaDoRodrigo.agencia = 1;
            contaDoRodrigo.numero = 123456;
            contaDoRodrigo.saldo = 1000;

            Console.WriteLine("Nome do titular da conta: " + contaDoRodrigo.titular);
            Console.WriteLine("Agência: " + contaDoRodrigo.agencia);
            Console.WriteLine("Numero da conta: " + contaDoRodrigo.numero);
            Console.WriteLine("Saldo R$" + contaDoRodrigo.saldo);

            contaDoRodrigo.saldo =+2000;

            Console.WriteLine("Saldo atualizado R$" + contaDoRodrigo.saldo);

            Console.WriteLine();
            Console.WriteLine("Execução finalizada pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
