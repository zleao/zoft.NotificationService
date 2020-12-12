using zoft.NotificationService.Messages.Base;

namespace zoft.NotificationService.Messages.TwoWay.Question
{
    /// <summary>
    /// Generic notification for question interface
    /// </summary>
    public class NotificationGenericQuestionMessage : NotificationTwoWayMessage
    {
        /// <summary>
        /// Gets the question.
        /// </summary>
        public string Question { get; }

        /// <summary>
        /// The possible answers.
        /// </summary>
        public NotificationTwoWayAnswersGroupEnum PossibleAnswers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGenericQuestionMessage" /> class.
        /// Will assume Yes and No as the possible answers
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="question">The question.</param>
        public NotificationGenericQuestionMessage(object sender, string question)
            : this(sender, question, NotificationTwoWayAnswersGroupEnum.YesNo)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGenericQuestionMessage" /> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="question">The question.</param>
        /// <param name="possibleAnswers">The possible answers.</param>
        public NotificationGenericQuestionMessage(object sender, string question, NotificationTwoWayAnswersGroupEnum possibleAnswers)
            : base(sender)
        {
            Question = question;
            PossibleAnswers = possibleAnswers;
        }
    }
}
