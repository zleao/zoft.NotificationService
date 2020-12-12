using zoft.NotificationService.Messages.Base;

namespace zoft.NotificationService.Messages
{
    /// <summary>
    /// One-Way message with string message
    /// </summary>
    public abstract class NotificationTextMessage : NotificationOneWayMessage
    {
        #region Properties

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTextMessage" /> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="message">The text message.</param>
        protected NotificationTextMessage(object sender, string message)
            : base(sender)
        {
            Message = message;
        }

        #endregion
    }
}