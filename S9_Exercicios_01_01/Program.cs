using S9_Exercicios_01_01.Entities;
using S9_Exercicios_01_01.Entities.Enums;
using System;
using System.Globalization;

namespace S9_Exercicios_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's Name: "); string nomeDpt = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: "); string nome = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel ou Senior): "); WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Convertendo Strig para Enum
            Console.Write("Base Salary: "); double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Department dept = new Department(nomeDpt);
            Worker trabalhador = new Worker(nome, nivel, salario, dept); // Instanciando 

            Console.Write("How Many contracts to this workes: ");
            int laco = int.Parse(Console.ReadLine());

            for (int y = 1; y <= laco; y++)
            {

                Console.WriteLine($"Enter #{y} contract data: ");
                Console.Write("Date DD/MM/YYYY: "); DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per Hour: "); double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours): "); int duracao = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, valorHora, duracao);
                trabalhador.AddContract(contrato);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): "); string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));// usar substring para recortar
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("nome: " + trabalhador.Name);
            Console.WriteLine("Departamento: " + trabalhador.Department.Name);
            Console.WriteLine("Income: for" + mesAno + ": " + trabalhador.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
