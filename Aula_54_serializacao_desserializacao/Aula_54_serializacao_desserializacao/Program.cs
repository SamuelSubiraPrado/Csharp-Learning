using System;

//Para que seja possível serializar uma classe, precisamos
//Desses 3 pacotes
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Aula_54_serializacao_desserializacao
{
    class Program
    {
        //Classe DOG já foi serializada (veja na pasta que tem a classe do programa)


        static void Main(string[] args)
        {

            Dog dog = new Dog("Max", "Stray-Dog", "Brown");
            

            DataContractSerializer serializer = new DataContractSerializer(typeof(Dog));
            
            //Serialização - Pegar um obj e transformar em um fluxo de bytes (string)
            //Criar um obj Xml
            XmlWriterSettings xmlSettings = new XmlWriterSettings { Indent = true};
            StringBuilder stringBuilder = new StringBuilder();
            
            XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, xmlSettings);
            
            serializer.WriteObject(xmlWriter, dog);
            //Finaliza a inscrição do xml
            xmlWriter.Flush();

            //Para pegar o conteudo:
            string serializedObject = stringBuilder.ToString();
            Console.WriteLine(serializedObject);

            //Salvando o conteúdo do objeto num XML

            //Com esse path, o conteudo vai para o locla do executavel do programa (dentro da bin)
            string MyFileXmlPath = "Dog.xml";
            FileStream myFileXml = File.Create(MyFileXmlPath);
            myFileXml.Close();
            //Escrevemos o conteúdo XML nele
            File.WriteAllText(MyFileXmlPath, serializedObject);
            //-------------------------------------------------------

            //Desserialização
            string serializedObjectContent = File.ReadAllText(MyFileXmlPath);
            StringReader stringReader = new StringReader(serializedObjectContent);
            XmlReader xmlReader = XmlReader.Create(stringReader);

            Console.WriteLine();
            Dog myDogDeserialized;
            myDogDeserialized = (Dog)serializer.ReadObject(xmlReader);
            Console.WriteLine(myDogDeserialized);
            
            xmlWriter.Close();
            xmlReader.Close();
        }
    }
}