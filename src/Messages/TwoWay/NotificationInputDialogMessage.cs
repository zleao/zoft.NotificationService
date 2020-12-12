using zoft.NotificationService.Messages.Base;

namespace zoft.NotificationService.Messages.TwoWay
{
    /// <summary>
    /// Input dialog notificaiton message
    /// </summary>
    public class NotificationInputDialogMessage : NotificationTwoWayMessage
    {
        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInputDialogMessage"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="message">The message.</param>
        public NotificationInputDialogMessage(object sender, string message)
            : base(sender)
        {
            Message = message;
        }
    }
}
