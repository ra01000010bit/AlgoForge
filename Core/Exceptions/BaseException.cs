using System.Runtime.Serialization;

namespace AlgoForge.Core.Exceptions
{
    /// <summary>
    /// Alap kivétel osztály az AlgoForge alkalmazás specifikus kivételekhez
    /// </summary>
    [Serializable]
    public abstract class AlgoForgeException : Exception
    {
        protected AlgoForgeException() : base() { }

        protected AlgoForgeException(string message) : base(message) { }

        protected AlgoForgeException(string message, Exception innerException)
            : base(message, innerException) { }

        protected AlgoForgeException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
