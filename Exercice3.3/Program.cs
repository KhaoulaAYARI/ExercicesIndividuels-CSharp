using Exercice3._3.Models;

namespace Exercice3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chanson ch1= new Chanson("Titre1","Artiste1");
            Chanson ch2 = new Chanson("Titre2", "Artiste2");
            Chanson ch3 = new Chanson("Titre3", "Artiste3");
            Chanson ch4 = new Chanson("Titre4", "Artiste4");
            Chanson ch5 = new Chanson("Titre5", "Artiste5");

            BiblioMusicale bib = new BiblioMusicale();
            bib.AddChonson(ch1);
            bib.AddChonson(ch2);
            bib.AddChonson(ch3);
            bib.AddChonson(ch4);
            bib.AddChonson(ch5);

            bib.LireChanson();
            bib.LireChanson();
            bib.LireChanson();
            bib.LireChanson();




        }
    }
}
