using System.Collections.Generic;

namespace zoft.NotificationService.Messages.TwoWay.Question
{
    /// <summary>
    /// Message for question with custom answer notification
    /// </summary>
    public class NotificationQuestionWithCustomAnswerMessage : NotificationGenericQuestionMessage
    {
        /// <summary>
        /// Gets the possible answers.
        /// </summary>
        /// <value>
        /// The possible answers.
        /// </value>
        public new IList<string> PossibleAnswers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationQuestionWithCustomAnswerMessage"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="question">The question.</param>
        /// <param name="possibleAnswers">The possible answers.</param>
        public NotificationQuestionWithCustomAnswerMessage(object sender, string question, IList<string> possibleAnswers)
            : base(sender, question, NotificationTwoWayAnswersGroupEnum.None)
        {
            PossibleAnswers = possibleAnswers;
        }
    }
}
