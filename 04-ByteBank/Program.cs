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
            Console.WriteLine("Executando projeto - C# - parte 2 - Aula 4 - Primeira função.");
            Console.WriteLine();

            ContaCorrente contaDoRodrigo = new ContaCorrente();

            contaDoRodrigo.titular = "Rodrigo Sundfeld";

            Console.WriteLine("O saldo da sua conta " + contaDoRodrigo.titular + " é de R$" + contaDoRodrigo.saldo);

            bool resultadoSaque =  contaDoRodrigo.Sacar(50);

            Console.WriteLine();
            Console.WriteLine("O saque foi efetivado? " + resultadoSaque);
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + " após o saque de R$" + contaDoRodrigo.saldo);

            bool resultadoSaque2 = contaDoRodrigo.Sacar(200);

            Console.WriteLine();
            Console.WriteLine("O saque foi efetivado? " + resultadoSaque2);
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + " após o saque de R$" + contaDoRodrigo.saldo);

            contaDoRodrigo.Depositar(500);
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + "após o deposito é de R$" + contaDoRodrigo.saldo);

            ContaCorrente contaDoLucas = new ContaCorrente();
            contaDoLucas.titular = "Lucas Sundfeld";

            Console.WriteLine();
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + " é de R$" + contaDoRodrigo.saldo);
            Console.WriteLine("O seu saldo " + contaDoLucas.titular + " é de R$" + contaDoLucas.saldo);

            bool resultadoTransferencia =  contaDoRodrigo.Transferir(100, contaDoLucas);

            Console.WriteLine();
            Console.WriteLine("A transferência foi realizada com sucesso? " + resultadoTransferencia);
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + " é de R$" + contaDoRodrigo.saldo);
            Console.WriteLine("O seu saldo " + contaDoLucas.titular + " é de R$" + contaDoLucas.saldo);

            bool resultadoTransferencia2 = contaDoLucas.Transferir(200, contaDoRodrigo);

            Console.WriteLine();
            Console.WriteLine("A transferência foi realizada com sucesso? " + resultadoTransferencia2);
            Console.WriteLine("O seu saldo " + contaDoRodrigo.titular + " é de R$" + contaDoRodrigo.saldo);
            Console.WriteLine("O seu saldo " + contaDoLucas.titular + " é de R$" + contaDoLucas.saldo);

            Console.WriteLine();
            Console.WriteLine("Execução finalizada pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}