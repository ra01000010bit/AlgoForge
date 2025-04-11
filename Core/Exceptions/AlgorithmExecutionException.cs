using AlgoForge.Core.Localization;
using System;
using System.Runtime.Serialization;

namespace AlgoForge.Core.Exceptions
{
    /// <summary>
    /// Algoritmus végrehajtás hibája esetén dobott kivétel
    /// </summary>
    [Serializable]
    public class AlgorithmExecutionException : AlgoForgeException
    {
        public AlgorithmExecutionException()
            : base(LanguageManager.Instance.GetMessage("AlgorithmExecutionError")) { }

        public AlgorithmExecutionException(string message)
            : base(message) { }

        public AlgorithmExecutionException(string message, Exception innerException)
            : base(message, innerException) { }

        protected AlgorithmExecutionException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}