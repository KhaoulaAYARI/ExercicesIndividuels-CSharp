using Exercice3._2.Models;

namespace Exercice3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ecole ecoleCentrale = new Ecole(new List<Etudiant>(), new List<Enseignant>(), new List<Classe>());

            Etudiant Alex = new Etudiant("Alex", 16);
            Etudiant Roni = new Etudiant("Roni", 17);
            Etudiant Julie = new Etudiant("Julie", 15);
            Etudiant Lila = new Etudiant("Lila", 16);
            Etudiant John = new Etudiant("John", 17);





            ecoleCentrale.AddEtudiant(Alex);
            ecoleCentrale.AddEtudiant(Roni);
            ecoleCentrale.AddEtudiant(Julie);
            ecoleCentrale.AddEtudiant(Lila);
            ecoleCentrale.AddEtudiant(John);

            Enseignant Sam = new Enseignant("Sam", "CS");
            Enseignant Alberto = new Enseignant("Alberto", "JAVA");
            Enseignant Emma = new Enseignant("Emma", "HTML");



            ecoleCentrale.AddEnseignant(Sam);
            ecoleCentrale.AddEnseignant(Alberto);
            ecoleCentrale.AddEnseignant(Emma);
            List<Enseignant> list_enseignants = new List<Enseignant>();
            list_enseignants.Add(Sam);
            list_enseignants.Add(Alberto);
            list_enseignants.Add(Emma);

            List<Etudiant> liste1= new List<Etudiant>();
            liste1.Add(Alex);
            liste1.Add(Roni);
            liste1.Add(Julie);

            List<Etudiant> liste2 = new List<Etudiant>();
            liste2.Add(Lila);
            liste2.Add(John);
            liste2.Add(Julie);

            List<Etudiant> liste3 = new List<Etudiant>();
            liste3.Add(Lila);
            liste3.Add(John);
            liste3.Add(Julie);
            liste3.Add(Roni);
            liste3.Add(Alex);


            Classe classe1 = new Classe("Classe1", Sam, liste1);
            Classe classe2 = new Classe("Classe2", Alberto, liste2);
            Classe classe3 = new Classe("Classe3", Emma, liste3);

            ecoleCentrale.AddClasse(classe1);
            ecoleCentrale.AddClasse(classe2);
            ecoleCentrale.AddClasse(classe3);
            List<Classe> liste_classes = new List<Classe>();
            liste_classes.Add(classe1);
            liste_classes.Add(classe2);
            liste_classes.Add(classe3);


            Console.WriteLine("la liste des classe:");
            foreach(Classe c in liste_classes)
            Console.WriteLine(c.GetNomClasse());

            Console.WriteLine("la liste des enseignants:");
            foreach (Enseignant e in list_enseignants)
            {
                Console.WriteLine(e.GetNom());
            }
            Console.WriteLine("la liste des enseignants de classe1:");
            Console.WriteLine(classe1.GetEnseignant().GetNom());





        }
    }
}
