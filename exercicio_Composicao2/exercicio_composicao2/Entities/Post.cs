using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_composicao2.Entities
{
    public class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comment { get; set; } = new List<Comentario>();

        public Post() { }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        } 

        public void AddComment(Comentario comments)
        {
            Comment.Add(comments);
        }

        public void RemoveComment(Comentario comments)
        {
            Comment.Remove(comments);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach(Comentario c in Comment)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
