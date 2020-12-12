using System;

namespace zoft.NotificationService.Exceptions
{
    /// <summary>
    /// Represents an exception specific for the notification plugin
    /// </summary>
    public class NotificationErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationErrorException" /> class.
        /// </summary>
        public NotificationErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationErrorException" /> class.
        /// </summary>
        /// <param name="message"></param>
        public NotificationErrorException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationErrorException" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NotificationErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
