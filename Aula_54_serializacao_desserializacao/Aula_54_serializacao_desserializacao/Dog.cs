using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Precisamos importar isso
using System.Runtime.Serialization;

namespace Aula_54_serializacao_desserializacao
{
    //Isso indica que queremos serializar essa classe
    [DataContract]
    internal class Dog
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Breed { get; set; }
        [DataMember]
        public string Color { get; set; }

        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }

        //Para serializar, temos que ter um construtor padrão
        public Dog() { }
    }
}
