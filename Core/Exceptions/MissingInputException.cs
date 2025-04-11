using AlgoForge.Core.Localization;
using System;
using System.Runtime.Serialization;

namespace AlgoForge.Core.Exceptions
{
    /// <summary>
    /// Hiányzó bemenet esetén dobott kivétel
    /// </summary>
    [Serializable]
    public class MissingInputException : AlgoForgeException
    {
        public MissingInputException()
            : base(LanguageManager.Instance.GetMessage("MissingInput")) { }

        public MissingInputException(string message)
            : base(message) { }

        public MissingInputException(string message, Exception innerException)
            : base(message, innerException) { }

        protected MissingInputException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}