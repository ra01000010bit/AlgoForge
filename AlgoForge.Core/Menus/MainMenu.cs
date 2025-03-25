using AlgoForge.AlgoForge.Core.Exceptions;
using AlgoForge.AlgoForge.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgoForge.AlgoForge.Core.Menus
{
    class MainMenu
    {
        public void Menu()
        {
            #region SetLanguage
            LanguageManager languageManager = new LanguageManager();
            languageManager.SelectLanguage();
            Console.Clear();
            #endregion

            Console.WriteLine(languageManager.GetMessage("Hello"));
            Console.WriteLine(languageManager.GetMessage("MenuPrompt"));
            Console.WriteLine(languageManager.GetMessage("SimpleProgTasks"));
            Console.WriteLine(languageManager.GetMessage("Option2"));
            Console.WriteLine(languageManager.GetMessage("Option3"));
            int mainAnswer;
            while (true)
            {
                Console.Write("Enter your choice (1-3): ");
                string input = Console.ReadLine();
                    
                    if (!int.TryParse(input, out mainAnswer) || mainAnswer < 1 || mainAnswer > 3)
                    {
                        
                        throw new InvalidInputException("InvalidInput");
                    }

                    // Ha a bemenet érvényes
                    break;
            }
        }
    }
}
