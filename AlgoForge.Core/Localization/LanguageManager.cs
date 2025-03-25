using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AlgoForge.AlgoForge.Core.Localization
{
    internal class LanguageManager
    {
        private ResourceManager resourceManager;
        
        public void SelectLanguage()
        {
            Console.WriteLine("Choose language / Válasszon nyelvet:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Magyar");

            int languageChoice;
            while (true)
            {
                Console.Write("Enter your choice (1-2): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out languageChoice) && (languageChoice == 1 || languageChoice == 2))
                {
                    string culture = languageChoice == 1 ? "en" : "hu";
                    resourceManager = new ResourceManager("AlgoForge.Resources.Messages", typeof(LanguageManager).Assembly);
                    CultureInfo.CurrentUICulture = new CultureInfo(culture);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
                }
            }
        }

        public string GetMessage(string key)
        {
            return resourceManager.GetString(key) ?? "Message not found!";
        }
    }
}

