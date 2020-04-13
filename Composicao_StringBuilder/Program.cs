using System;
using Composicao_StringBuilder.Entities;

namespace Composicao_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment C1 = new Comment("Have a nice trip!");
            Comment C2 = new Comment("How That's awesome!");
            Post P1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderfull country!");
            Post.AddComment(C1);
            Post.AddComment(C2);


        }

    }
}
