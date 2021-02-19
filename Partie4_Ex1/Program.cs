using System;

namespace Partie4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of the array
            string[] week = new string[] {"lundi", "mardi", "mercredi", "jedi","vendredi", "samedi" };

            Console.WriteLine($"l'indice numéro 1 est { week[1]},\net l'indice numéro 4 est { week[4]}");
            Console.WriteLine($"le contenu du 1er élement est { week[0]},\net le contenu du 4ème élément est { week[3]}");

            //changer une donnée en la redéfinissant
            week[3] = "jeudi";
            Console.WriteLine($"la modification a été faite, à présent c'est { week[3]} ");

            //fonction ajout "arrayresize" + référence du tableau + taille 
            Array.Resize<string>(ref week, 7);
            week[6] = "dimanche";
            Console.WriteLine($"un dernier jour est ajouté { week[6]} ");

            //boucle pour parcourir un tableau sans se soucier de la taille et l'afficher dans day
            foreach(string day in week)
                {
            Console.WriteLine(day);
            }
            
        }
        }
    }

