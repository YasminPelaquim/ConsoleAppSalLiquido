using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário bruto: ");
            int bruto = int.Parse(Console.ReadLine());

            Console.WriteLine("Vale alimentação: ");
            int ali = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de filhos: ");
            int filho = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por filho: ");
            int valfilho = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas extras: ");
            int hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora extra: ");
            int valhora = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS: ");
            int inss = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF: ");
            int irpf = int.Parse(Console.ReadLine());

            double salliquido = bruto + ali + (filho * valfilho) + (hora * valhora) - inss - irpf;

            Console.WriteLine("O salário líquido do/a funcionário/a é de: R$" + salliquido);
            Console.ReadKey();

        }
    }
}
