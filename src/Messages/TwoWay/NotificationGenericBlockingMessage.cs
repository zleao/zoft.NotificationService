using System;
using zoft.NotificationService.Messages.Base;

namespace zoft.NotificationService.Messages.TwoWay
{
    /// <summary>
    /// Generic notification for messages that should block the UI from other interactions
    /// </summary>
    [Obsolete("Notification not needed anymore. Use GenericNotificationMessage with MessageBox instead")]
    public class NotificationGenericBlockingMessage : NotificationTwoWayMessage
    {
        /// <summary>
        /// Notification severity level
        /// </summary>
        public NotificationSeverityEnum Severity { get; }

        /// <summary>
        /// Message to show.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGenericBlockingMessage"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="severity">The severity.</param>
        /// <param name="message">The message.</param>
        public NotificationGenericBlockingMessage(object sender, NotificationSeverityEnum severity, string message)
            : base(sender)
        {
            Message = message;
            Severity = severity;
        }
    }
}
