namespace zoft.NotificationService.Messages.TwoWay.Result
{
    /// <summary>
    /// Message for question custom answer result notification
    /// </summary>
    public class NotificationQuestionCustomAnswerResult : INotificationResult
    {
        /// <summary>
        /// Gets the selected answer.
        /// </summary>
        /// <value>
        /// The selected answer.
        /// </value>
        public string SelectedAnswer { get; }

        /// <summary>
        /// Gets the index of the selected answer.
        /// </summary>
        /// <value>
        /// The index of the selected answer.
        /// </value>
        public int SelectedAnswerIndex { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationQuestionCustomAnswerResult"/> class.
        /// </summary>
        /// <param name="selectedAnswer">The selected answer.</param>
        /// <param name="selectedAnswerIndex">Index of the selected answer.</param>
        public NotificationQuestionCustomAnswerResult(string selectedAnswer, int selectedAnswerIndex)
        {
            SelectedAnswer = selectedAnswer;
            SelectedAnswerIndex = selectedAnswerIndex;
        }
    }
}
