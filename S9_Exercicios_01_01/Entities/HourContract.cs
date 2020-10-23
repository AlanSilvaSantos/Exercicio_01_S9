using System;

namespace S9_Exercicios_01_01.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } // Atributos
        public double ValuePerHour { get; set; } // Atributos
        public int Hours { get; set; } // Atributos

        public HourContract() // Construtor padrão
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) // Construtor com argumentos
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        private double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
