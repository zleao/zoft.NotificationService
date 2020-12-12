using System;

namespace zoft.NotificationService.Core
{
    /// <summary>
    /// Subscription token
    /// </summary>
    public class SubscriptionToken
    {
        #region Properties

        /// <summary>
        /// Notification type
        /// </summary>
        public Type MessageType { get; }

        /// <summary>
        /// Subscription context.
        /// </summary>
        public string Context { get; }

        /// <summary>
        /// Unique subscription token identifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// The dependent objects.
        /// </summary>
        public object[] DependentObjects { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionToken" /> class.
        /// </summary>
        /// <param name="MessageType">Type of the message.</param>
        /// <param name="context">The context.</param>
        /// <param name="id">The id.</param>
        /// <param name="dependentObjects">The dependent objects.</param>
        public SubscriptionToken(Type MessageType, string context, Guid id, params object[] dependentObjects)
        {
            this.MessageType = MessageType;
            Context = context;
            Id = id;
            DependentObjects = dependentObjects;
        }

        #endregion
    }
}