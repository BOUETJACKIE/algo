using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algoexercice1.MenuPerso;

namespace algoexercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            {
                menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "menu 1" });
                menu.InsererLigne(new MenuItem { Numero = 2, Libelle = "menu 2" });
                menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3" });
                menu.InsererLigne(new MenuItem { Numero = 4, Libelle = "menu 4" });
                menu.InsererLigne(new MenuItem { Numero = 5, Libelle = "menu 5" });
                menu.InsererLigne(new MenuItem { Numero = 6, Libelle = "menu 6" });

                menu.AfficherMenu();

                int resultat = menu.Choisir();
                Console.WriteLine(resultat);
                Console.ReadLine();
            }
            
        }
       

        

    }
    




}
