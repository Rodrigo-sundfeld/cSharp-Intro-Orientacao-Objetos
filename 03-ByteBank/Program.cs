using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - C# - parte 2 - Aula 3 - Tipos de referência e tipos de valor.");
            Console.WriteLine();

            ContaCorrente contaDoRodrigo = new ContaCorrente();
            contaDoRodrigo.titular = "Rodrigo Sundfeld";
            contaDoRodrigo.agencia = 1;
            contaDoRodrigo.numero = 123456;

            ContaCorrente contaDoRodrigoSundfeld = new ContaCorrente();
            contaDoRodrigoSundfeld.titular = "Rodrigo Sundfeld";
            contaDoRodrigoSundfeld.agencia = 1;
            contaDoRodrigoSundfeld.numero = 123456;

            Console.WriteLine("Comparação de igualdade de tipo referência --> " + 
                (contaDoRodrigo == contaDoRodrigoSundfeld)); // comparação de variáveis do tipo referência endereço de memória diferentes

            int idade = 41;
            int idade2 = 41;

            Console.WriteLine("Comparação de igualdade de tipo valor --> " + 
                (idade == idade2)); // comparação de variáveis do tipo valor

            contaDoRodrigo = contaDoRodrigoSundfeld;

            Console.WriteLine("Comparação de igualdade de tipo referência 2 --> "+ 
                (contaDoRodrigo == contaDoRodrigoSundfeld));

            contaDoRodrigo.saldo = 300;
            Console.WriteLine(contaDoRodrigo.saldo);
            Console.WriteLine(contaDoRodrigoSundfeld.saldo);

            Console.WriteLine();
            Console.WriteLine("Execução finalizada pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
