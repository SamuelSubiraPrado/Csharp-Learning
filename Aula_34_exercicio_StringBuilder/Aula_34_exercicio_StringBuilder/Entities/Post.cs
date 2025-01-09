using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34_exercicio_StringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public int Likes {  get; set; }
        // Instanciamos a lista, para garantir que ela será iniciada.
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() 
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) 
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            //Se ficarmos usando muitas concatenações, o
            //programa ficará muito pesado, por esse motivo
            //vamos usar o StringBuilder, ele é responsável
            //por fazer a montagem de uma string que voce mandar
            //de uma forma super eficiente e depois que estiver pronto
            //voce pega o resultado em forma de string
            
            StringBuilder sb = new StringBuilder();
            //Append adiciona um texto no fim do SB
            //Append Line, adiciona texto no final e
            //coloca uma quebra de linha
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" - ");
            //Nessa data temos que colocar uma mascara para formatação
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
