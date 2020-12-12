using zoft.NotificationService.Messages.TwoWay.Question;

namespace zoft.NotificationService.Messages.TwoWay.Result
{
    /// <summary>
    /// Generic result for question notifications
    /// </summary>
    public class NotificationGenericQuestionResult : NotificationQuestionAnswerResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGenericQuestionResult"/> class.
        /// </summary>
        /// <param name="answer">The answer.</param>
        public NotificationGenericQuestionResult(NotificationTwoWayAnswersEnum answer)
            : base(answer)
        {
        }
    }
}
