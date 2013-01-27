using System;
using System.Runtime.Serialization;

namespace MongoRepository.Exceptions
{
    /// <summary>
    /// Represents a MongoRepository exception
    /// </summary>
    [Serializable]
    public class MongoRepositoryException : Exception
    {
        // constructors
        
        /// <summary>
        /// Initializes a new instance of the MongoRepository class.
        /// </summary>
        /// <param name="message">The error message.</param>
        public MongoRepositoryException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MongoRepository class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public MongoRepositoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MongoRepository class (this overload supports deserialization).
        /// </summary>
        /// <param name="info">The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        public MongoRepositoryException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
