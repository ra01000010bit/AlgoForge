using AlgoForge.Core.Localization;
using System.Runtime.Serialization;

namespace AlgoForge.Core.Exceptions
{
    /// <summary>
    /// Érvénytelen bemenet esetén dobott kivétel
    /// </summary>
    [Serializable]
    public class InvalidInputException : AlgoForgeException
    {
        public InvalidInputException()
            : base(LanguageManager.Instance.GetMessage("InvalidInput")) { }

        public InvalidInputException(string message)
            : base(message) { }

        public InvalidInputException(string message, Exception innerException)
            : base(message, innerException) { }

        protected InvalidInputException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}