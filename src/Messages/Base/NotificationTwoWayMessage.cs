namespace zoft.NotificationService.Messages.Base
{
    /// <summary>
    /// Two-Way notification
    /// </summary>
    public abstract class NotificationTwoWayMessage : NotificationMessage, INotificationTwoWayMessage
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTwoWayMessage" /> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        protected NotificationTwoWayMessage(object sender)
            : base(sender)
        {
        }

        #endregion
    }
}
