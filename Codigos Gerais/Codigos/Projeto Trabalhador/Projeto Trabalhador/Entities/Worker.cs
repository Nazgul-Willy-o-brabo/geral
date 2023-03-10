using Projeto_Trabalhador.Entities.Enum;
using System.Collections.Generic;

namespace Projeto_Trabalhador.Entities
{
    class Worker
    {
        //propriedades
        private String _name;
        private WorkerLevel _level;
        private double _baseSalary;
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //encapsulamento
        public string Name { get => _name; set => _name = value; }
        public WorkerLevel Level { get => _level; set => _level = value; }
        public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }

        //Construtores
        public Worker() { }
        public Worker(Department department, string name, WorkerLevel level, double baseSalary)
        {
            Department = department;
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }


        //Funções
        public void AddContrct(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContrct(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income/*renda*/(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }

}
