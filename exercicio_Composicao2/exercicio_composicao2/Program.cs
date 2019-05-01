using exercicio_composicao2.Entities;
using System;

namespace exercicio_composicao2
{
    class Program
    {
        static void Main(string[] args)
        {

            Comentario c1_1 = new Comentario() { Text = "Have a nice trip"};
            Comentario c1_2 = new Comentario() { Text = "Wow that's awesome!" };
            Post post1 = new Post() { Date = new DateTime(2018,06,21,13,05,44),  Title= "Traveling to New Zeland !", Content= "I'm going to visit this wonderful country :D", Likes=12};
            post1.AddComment(c1_1);
            post1.AddComment(c1_2);

            Comentario c2_1 = new Comentario() { Text = "Good night" };
            Comentario c2_2 = new Comentario() { Text = "May the Force be with you !" };
            Post post2 = new Post() { Date = new DateTime(2018,07,28,23,14,19), Title = "Good Night guys! ", Content = "See you tomorrow ", Likes = 5 };
            post2.AddComment(c2_1);
            post2.AddComment(c2_2);


            Console.WriteLine(post1);
            Console.WriteLine(post2);



        }
    }
}
