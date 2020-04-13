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
            Likes -= 1;
        }

        public static void AddComment(Comment coment)
        {
            Comments.Add(coment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
