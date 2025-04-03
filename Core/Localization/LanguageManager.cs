using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace AlgoForge.Core.Localization
{
    internal class LanguageManager
    {
        private static LanguageManager instance;
        private ResourceManager resourceManager;
        private CultureInfo currentCulture;

        private LanguageManager()
        {
            resourceManager = new ResourceManager("AlgoForge.Resources.Messages", Assembly.GetExecutingAssembly());
            currentCulture = CultureInfo.InvariantCulture;
        }

        public static LanguageManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LanguageManager();
                }
                return instance;
            }
        }

        public void SelectLanguage()
        {
            Console.WriteLine("Choose language / Válasszon nyelvet:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Magyar");

            int choice;
            while (true)
            {
                Console.Write("Enter your choice (1-2): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                {
                    string culture = choice == 1 ? "en" : "hu";
                    currentCulture = new CultureInfo(culture);
                    CultureInfo.CurrentUICulture = currentCulture;
                    Console.WriteLine($"Language set to: {currentCulture.DisplayName}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. / Rossz válasz.");
                }
            }
        }

        public string GetMessage(string key)
        {
            try
            {
                return resourceManager.GetString(key, currentCulture) ?? "Message not found!";
            }
            catch (MissingManifestResourceException)
            {
                Console.WriteLine("Resource file not found! Available resources:");
                foreach (var resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                {
                    Console.WriteLine(resource);
                }
                return "Resource file missing!";
            }
        }
    }
}
