using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto - C# - parte 2 - Introdução a O.O. - Aula 2 - Valores Padrões");
            Console.WriteLine();

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Lucas Fehr Sundfeld";
            conta.saldo = 1000;


            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.saldo);

            Console.WriteLine();
            Console.WriteLine("Execução finalizada pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
