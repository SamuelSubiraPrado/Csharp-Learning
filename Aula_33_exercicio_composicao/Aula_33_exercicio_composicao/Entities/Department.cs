using System;

namespace Aula_33_exercicio_composicao.Entities
{
    internal class Department
    {
        public string Name {  get; set; }

        public Department(){ }

        public Department(string name)
        {
            Name = name;
        }

    }
}
