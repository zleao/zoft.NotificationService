using zoft.NotificationService.Messages.TwoWay.Question;

namespace zoft.NotificationService.Messages.TwoWay.Result
{
    /// <summary>
    /// Result for question notifications
    /// </summary>
    public class NotificationQuestionAnswerResult : INotificationResult
    {
        /// <summary>
        /// The answer.
        /// </summary>
        public NotificationTwoWayAnswersEnum Answer { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationQuestionAnswerResult" /> class.
        /// </summary>
        /// <param name="answer">The answer.</param>
        public NotificationQuestionAnswerResult(NotificationTwoWayAnswersEnum answer)
        {
            Answer = answer;
        }
    }
}
