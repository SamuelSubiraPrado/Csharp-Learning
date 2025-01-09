using System;
//Temos que importar para usar as listas
using System.Collections.Generic;
using System.Diagnostics.Contracts;

//Chamando o Enum que criamos na pasta
using Aula_33_exercicio_composicao.Entities.Enums;

namespace Aula_33_exercicio_composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary {  get; set; }

        //Associação(Composição) entre as classes diferentes
        public Department Department { get; set; }
        //Colocamos uma lista, por que um trabalhador tem vários contratos
                                    //Já instanciamos para garantir que não seja nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            Level = level;
            BaseSalary = baseSalary;
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
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
