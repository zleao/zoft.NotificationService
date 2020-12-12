namespace zoft.NotificationService.Messages.TwoWay.Result
{
    /// <summary>
    /// Notification result for the InputDialog message
    /// </summary>
    public class NotificationInputDialogResult : INotificationResult
    {
        /// <summary>
        /// The answer.
        /// </summary>
        public string Answer { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationInputDialogResult"/> class.
        /// </summary>
        /// <param name="answer">The answer.</param>
        public NotificationInputDialogResult(string answer)
        {
            Answer = answer;
        }
    }
}
