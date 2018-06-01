using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoexercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //création d'une nouvelle liste + intégration des nouveaux élements
            List<MenuItem> list = new List<MenuItem>
            {
             new MenuItem{Numero=1, Libelle = "menu 1" },
             new MenuItem{Numero=2, Libelle = "menu 2" },
             new MenuItem{Numero=3, Libelle = "menu 3" },
             new MenuItem{Numero=4, Libelle = "menu 4" },
             new MenuItem{Numero=5, Libelle = "menu 5" },
             new MenuItem{Numero=6, Libelle = "menu 6" },
            };
            // création d'une variable (résultat) pour afficher la liste
            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
        /// <summary>
        /// affiche une menu et récupère la saisie de l'utilisateur
        /// </summary>
        /// <param name="menu">la liste des choix possibles</param>
        /// <returns>le choix de l'utilisateur</returns>
        private static int GererMenu(List<MenuItem> menu)
        {
            //affiche les élements du menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}.{ligne.Libelle}");
            }
            // récupération du choix de l'utilisateur
            Console.WriteLine("saisir un choix");
            int choix;

            choix = int.Parse(Console.ReadLine());

            //test du choix par rapport aux élément du menu
            while (true)
            {
                foreach (MenuItem item in menu)
                {
                    if (choix == item.Numero)
                    {

                        return choix;
                    }
                }
                // ou bien return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;

                Console.WriteLine("Erreur, saisir un choix:");
            }
            //return -1;

        }

    }
    /// <summary>
    /// représente une ligne d'un menu 
    /// </summary>
    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }

    }




}
