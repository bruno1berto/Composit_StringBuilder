using System;
using System.Collections.Generic;

namespace Composicao_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }

        public Post(DateTime moment, string title, string content) : this(moment)
        {
            Title = title;
            Content = content;
        }
        public Post(DateTime moment)
        {
            Moment = moment;
        }
    }
}
