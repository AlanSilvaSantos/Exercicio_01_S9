using S9_Exercicios_01_01.Entities.Enums;
using System;
using System.Collections.Generic;

namespace S9_Exercicios_01_01.Entities
{
    class Worker
    {
        // Atributos/Parametros
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        //Construtor Padrão, vazio
        public Worker()
        {
        }
        // Construtor com argumentos
        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double suma = BaseSalary;

            foreach (HourContract contract in Contracts) // Percorrer contratos
            {
                if (contract.Date.Year == year && contract.Date.Month == month) 
                {
                    suma += contract.TotalValue();
                }
            }
            return suma;
        }

    }
}
