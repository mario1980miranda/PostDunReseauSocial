using System;
using PostDunReseauSocial.Entities;

namespace PostDunReseauSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Bon voyage!!!");
            Comment c2 = new Comment("C'est cool...");

            Post p1 = new Post(
                DateTime.Parse("2018-06-21 13:05:44"),
                "Voyager en Nouvelle-Zélande",
                "Je vais visiter ce beau pays!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Bonsoir");
            Comment c4 = new Comment("Que la force soit avec toi!");

            Post p2 = new Post(
                DateTime.Parse("2018-07-28 23:14:09"),
                "Bonsoir les gens!",
                "À demain",
                7
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
