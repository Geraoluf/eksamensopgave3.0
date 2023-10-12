using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksamensopgave3._0
{
    public class Morgenmenu
    {
       public string menuTitle; 

        Dictionary<string, List<string>> menuDictionary = new Dictionary<string, List<string>>();

        public void metode()
        {
            // Få brugerinput til menu
            Console.WriteLine("Indtast menuens titel:");
            string menuTitle = Console.ReadLine();


            // Få brugerinput til ingredienser
            List<string> ingredients = new List<string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Indtast ingrediens {i}: ");
                string ingredient = Console.ReadLine();
                ingredients.Add(ingredient);
            }

            // Tilføj menuen til dictionary
            menuDictionary.Add(menuTitle, ingredients);


        }

    }
}
