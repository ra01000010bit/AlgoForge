using AlgoForge.Core.Localization;
using System;
using System.Runtime.Serialization;

namespace AlgoForge.Core.Exceptions
{
    /// <summary>
    /// Adatelérési vagy adatkezelési hiba esetén dobott kivétel
    /// </summary>
    [Serializable]
    public class DataAccessException : AlgoForgeException
    {
        public DataAccessException()
            : base(LanguageManager.Instance.GetMessage("DataAccessError")) { }

        public DataAccessException(string message)
            : base(message) { }

        public DataAccessException(string message, Exception innerException)
            : base(message, innerException) { }

        protected DataAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
