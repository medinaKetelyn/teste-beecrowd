using System.Drawing;

namespace Beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Double num1 = double.Parse(Console.ReadLine());
            //    Double num2 = double.Parse(Console.ReadLine());
            //    Double peso1 = 3.5;
            //    Double peso2 = 7.5;
            //    Double media = (num1*peso1) + (num2*peso2) / (peso1+peso2);
            //    Console.WriteLine($"MEDIA = {media:0.00000}");

            //Double nota1 = double.Parse(Console.ReadLine());
            //Double nota2 = double.Parse(Console.ReadLine());
            //Double nota3 = double.Parse(Console.ReadLine());
            //Double peso1 = 2;
            //Double peso2 = 3;
            //Double peso3 = 5;
            //Double media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);
            //Console.WriteLine($"MEDIA = {media:0.0}");

            //int num1 = Int32.Parse(Console.ReadLine());
            //int num2 = Int32.Parse(Console.ReadLine());
            //int num3 = Int32.Parse(Console.ReadLine());
            //int num4 = Int32.Parse(Console.ReadLine());
            //int diferenca = (num1 * num2) - (num3 * num4);
            //Console.WriteLine($"DIFERENCA = {diferenca}");

            //int numFuncionario = Int32.Parse(Console.ReadLine());
            //int hrsTrabalhada = Int32.Parse(Console.ReadLine());
            //Double valorHora = double.Parse(Console.ReadLine());
            //Double salario = hrsTrabalhada * valorHora;
            //Console.WriteLine($"NUMBER = {numFuncionario}\nSALARY = U$ {salario:0.00}");

            //String nome = Console.ReadLine();
            //Double salarioFixo = double.Parse(Console.ReadLine());
            //Double totalVendasMes = double.Parse(Console.ReadLine());
            //Double total = (totalVendasMes * 0.15)+salarioFixo;
            //Console.WriteLine($"TOTAL = R$ {total:0.00}");

            string[] inputs1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(inputs1[0]);
            int numPeca1 = int.Parse(inputs1[1]);
            double valorPeca1 = double.Parse(inputs1[2]);

            string[] inputs2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(inputs2[0]);
            int numPeca2 = int.Parse(inputs2[1]);
            double valorPeca2 = double.Parse(inputs2[2]);

            Double total = (valorPeca1*numPeca1) + (valorPeca2*numPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total:0.00}");
        }

    }
}
