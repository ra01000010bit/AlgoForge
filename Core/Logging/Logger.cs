using System;
using System.IO;
using AlgoForge.Core.Enums;
using System.Text;
using AlgoForge.Core.Exceptions;

namespace AlgoForge.Core.Utilities
{
    /// <summary>
    /// Naplózó osztály, amely kivételek és egyéb üzenetek naplózására szolgál.
    /// Singleton tervezési mintát használ, tehát csak egyetlen példánya létezik.
    /// </summary>
    public class Logger
    {
        #region Singleton megvalósítás

        // Szálbiztonsághoz szükséges zároló objektum
        private static readonly object _lock = new object();

        // Az egyetlen példány tárolására szolgáló statikus változó
        private static Logger _instance;

        /// <summary>
        /// Visszaadja a Logger osztály egyetlen példányát (Singleton minta)
        /// Ha még nem létezik, akkor létrehozza.
        /// </summary>
        public static Logger Instance
        {
            get
            {
                // Kétszeres ellenőrzés zárolással (Double-Check Locking)
                // Először ellenőrizzük zárolás nélkül a teljesítmény érdekében
                if (_instance == null)
                {
                    // Ha null, akkor zárolunk, hogy más szálak ne hozzanak létre példányt
                    lock (_lock)
                    {
                        // Ellenőrizzük ismét, mert egy másik szál létrehozhatta közben
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Változók és konstruktor

        // A log fájl elérési útja
        private readonly string _logFilePath;

        // A log fájlokat tartalmazó könyvtár
        private readonly string _logDirectory;

        /// <summary>
        /// Privát konstruktor, hogy kívülről ne lehessen példányosítani (Singleton minta).
        /// Inicializálja a naplózási könyvtárat és fájlt, majd ellenőrzi azok létezését.
        /// </summary>
        private Logger()
        {
            // A log könyvtár a futtatható fájl mellett, a Data/Logs mappában lesz
            _logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Logs");

            // A log fájl neve tartalmazza az aktuális dátumot (napi log)
            _logFilePath = Path.Combine(_logDirectory, $"log_{DateTime.Now:yyyyMMdd}.txt");

            // Ellenőrizzük és ha szükséges, létrehozzuk a log fájlt
            EnsureLogFileExists();
        }

        #endregion

        #region Privát segédmetódusok

        /// <summary>
        /// Ellenőrzi, hogy létezik-e a log fájl és a könyvtárstruktúra.
        /// Ha nem léteznek, akkor létrehozza őket.
        /// </summary>
        private void EnsureLogFileExists()
        {
            try
            {
                // Ellenőrizzük, hogy létezik-e a mappahierarchia, ha nem, létrehozzuk
                // Ez rekurzívan létrehozza az összes szükséges szülő mappát is
                if (!Directory.Exists(_logDirectory))
                {
                    Directory.CreateDirectory(_logDirectory);
                    Console.WriteLine($"Log mappa létrehozva: {_logDirectory}");
                }

                // Ellenőrizzük, hogy létezik-e a log fájl, ha nem, létrehozzuk
                if (!File.Exists(_logFilePath))
                {
                    // A File.Create visszaad egy FileStream objektumot, amit be kell zárni
                    using (FileStream fs = File.Create(_logFilePath))
                    {
                        // Fejléc hozzáadása az új log fájlhoz
                        string header = $"Log fájl létrehozva: {DateTime.Now}\r\n" +
                                        $"----------------------------------------------------\r\n";
                        byte[] headerBytes = Encoding.UTF8.GetBytes(header);
                        fs.Write(headerBytes, 0, headerBytes.Length);
                    }
                    Console.WriteLine($"Log fájl létrehozva: {_logFilePath}");
                }
            }
            catch (Exception ex)
            {
                // Ha a log fájlt sem tudjuk létrehozni, akkor a konzolon jelezzük
                // Itt nem tudunk saját kivételt dobni vagy naplózni, mert épp a naplózót inicializáljuk
                Console.WriteLine($"Kritikus hiba történt a log fájl létrehozása közben: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        #endregion

        #region Nyilvános naplózó metódusok

        /// <summary>
        /// Naplózza a megadott kivételt a log fájlba részletes információkkal.
        /// </summary>
        /// <param name="ex">A naplózandó kivétel</param>
        /// <param name="additionalInfo">Opcionális kiegészítő információ</param>
        public void LogException(Exception ex, string additionalInfo = "")
        {
            try
            {
                // Zárolás, hogy egyszerre csak egy szál írhasson a fájlba
                lock (_lock)
                {
                    // A using blokk után a StreamWriter automatikusan bezáródik
                    using (StreamWriter writer = new StreamWriter(_logFilePath, true, Encoding.UTF8))
                    {
                        writer.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - HIBA");

                        // Az AlgoForgeException leszármazottai esetén külön kezelés
                        if (ex is AlgoForgeException algoEx)
                        {
                            writer.WriteLine($"AlgoForge kivétel típusa: {algoEx.GetType().Name}");
                        }
                        else
                        {
                            writer.WriteLine($"Kivétel típusa: {ex.GetType().Name}");
                        }

                        writer.WriteLine($"Üzenet: {ex.Message}");

                        // Opcionális kiegészítő információ kiírása, ha van
                        if (!string.IsNullOrEmpty(additionalInfo))
                        {
                            writer.WriteLine($"További információ: {additionalInfo}");
                        }

                        // Stack trace kiírása, ha rendelkezésre áll
                        if (ex.StackTrace != null)
                        {
                            writer.WriteLine($"Stack trace: {ex.StackTrace}");
                        }

                        // Belső kivétel naplózása, ha van
                        if (ex.InnerException != null)
                        {
                            writer.WriteLine($"Belső kivétel típusa: {ex.InnerException.GetType().Name}");
                            writer.WriteLine($"Belső kivétel üzenete: {ex.InnerException.Message}");

                            // Ha van belső stack trace, azt is kiírjuk
                            if (ex.InnerException.StackTrace != null)
                            {
                                writer.WriteLine($"Belső kivétel stack trace: {ex.InnerException.StackTrace}");
                            }
                        }

                        writer.WriteLine("----------------------------------------------------");
                    }
                }
            }
            catch (Exception logEx)
            {
                // Ha a naplózás közben hiba történik, a konzolon jelezzük
                Console.WriteLine($"Hiba történt a kivétel naplózása közben: {logEx.Message}");
                Console.WriteLine($"Eredeti kivétel: {ex.Message}");
            }
        }

        /// <summary>
        /// Naplóz egy egyszerű üzenetet a megadott súlyossági szinttel.
        /// </summary>
        /// <param name="message">A naplózandó üzenet</param>
        /// <param name="level">A naplózás súlyossági szintje (alapértelmezett: Info)</param>
        public void LogMessage(string message, LogLevel level = LogLevel.Info)
        {
            try
            {
                // Zárolás a szálbiztossághoz
                lock (_lock)
                {
                    using (StreamWriter writer = new StreamWriter(_logFilePath, true, Encoding.UTF8))
                    {
                        writer.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - {level}");
                        writer.WriteLine($"Üzenet: {message}");
                        writer.WriteLine("----------------------------------------------------");
                    }
                }

                // Kritikus hibáknál a konzolon is jelezzük
                if (level == LogLevel.Fatal || level == LogLevel.Error)
                {
                    Console.WriteLine($"[{level}] {message}");
                }
            }
            catch (Exception ex)
            {
                // Ha a naplózás közben hiba történik, a konzolon jelezzük
                Console.WriteLine($"Hiba történt az üzenet naplózása közben: {ex.Message}");
                Console.WriteLine($"Eredeti üzenet: {message}");
            }
        }

        /// <summary>
        /// Speciális metódus az AlgoForge alkalmazás kivételeinek naplózására.
        /// </summary>
        /// <param name="ex">Az AlgoForge típusú kivétel</param>
        /// <param name="additionalInfo">Kiegészítő információ</param>
        public void LogAlgoForgeException(AlgoForgeException ex, string additionalInfo = "")
        {
            try
            {
                lock (_lock)
                {
                    using (StreamWriter writer = new StreamWriter(_logFilePath, true, Encoding.UTF8))
                    {
                        writer.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - ALGOFORGE HIBA");
                        writer.WriteLine($"Kivétel típusa: {ex.GetType().Name}");
                        writer.WriteLine($"Üzenet: {ex.Message}");

                        if (!string.IsNullOrEmpty(additionalInfo))
                        {
                            writer.WriteLine($"További információ: {additionalInfo}");
                        }

                        if (ex.StackTrace != null)
                        {
                            writer.WriteLine($"Stack trace: {ex.StackTrace}");
                        }

                        writer.WriteLine("----------------------------------------------------");
                    }
                }
            }
            catch (Exception logEx)
            {
                Console.WriteLine($"Hiba történt az AlgoForge kivétel naplózása közben: {logEx.Message}");
            }
        }

        #endregion
    }
}