using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoexercice1.MenuPerso


{

    /// <summary>
    /// pour faire un menu 
    /// </summary>
    class Menu

    {
        private List<MenuItem> menuItems;

        internal void InsererLigne(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        // si type.(List)...valeur null, si type int valeur 0
        public Menu()
        {
            menuItems = new List<MenuItem>();

        }
        /// <summary>
        /// insère un menuItem dans le menu 
        /// </summary>
        /// <param name="item">element à inserer dans le menu</param>
        /// <exception cref="ArgumentException">si le numéro de l'item est déjà présent dans le menu </exception>    

        public void InserLigne(MenuItem item)
        {
            foreach (var ligne in menuItems)
            {
                if (ligne.Numero == item.Numero)
                { throw new ArgumentException($"Le numéro {item.Numero}existe déjà dans le menu "); }
            }
            // 2eme version: menuItems.Exists(x=>x.Numeroitem.Numero)){ throw new ArgumentException($"Le numéro {item.Numero}existe déjà dans le menu "); }
            menuItems.Add(item);

        }

        /// <summary>
        /// affiche les éléments du menu
        /// </summary>
        public void AfficherMenu()
        {
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Numero}.{ligne.Libelle}");
            }
        }

        /// <summary>
        /// récupération du choix de l'utilisa  teur par rapport aux éléments
        /// </summary>
        /// <returns>choix de l'utilisateur</returns>
        public int Choisir()
        {
            Console.WriteLine("saisir un choix");
            int choix;

            choix = int.Parse(Console.ReadLine());


            while (true)
            {
                foreach (MenuItem item in menuItems)
                {
                    if (choix == item.Numero)
                    {

                        return choix;
                    }
                }

                Console.WriteLine("Erreur, saisir un choix:");
            }
        }
    }
       
}
