using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao_StringBuilder.Entities
{
    class Post
    {
        public static DateTime Moment { get; set; }
        public static string Title { get; set; }
        public static string Content { get; set; }
        public static int Likes { get; set; }
        public static List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content)
        {
            Moment = moment;
            Title = title;
            Content = content;
        }
        public Post(DateTime moment)
        {
            Moment = moment;
        }

        public void AddLike()
        {
            Likes += 1;
        }
        public void RemoveLike()
        {
            if (Likes == 0)
            {
                Console.WriteLine("Operação inválida no momento.");
            }
            else
            {
                Likes -= 1;
            }
        }

        public void AddComment(Comment coment)
        {
            Comments.Add(coment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Like(s) - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            int nLikes = 0;
            foreach (Comment c in Comments)
            {
                nLikes += 1;
            }

            sb.Append(nLikes);
            sb.AppendLine(" Comment(s):");

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
