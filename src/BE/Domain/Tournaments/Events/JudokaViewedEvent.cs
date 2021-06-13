namespace JTSystem.Domain.Tournaments.Events
{
    using JTSystem.Domain.Common;

    public class JudokaViewedEvent : IDomainEvent
    {
        internal JudokaViewedEvent(int judokaId)
        {
            this.JudokaId = judokaId;
        }

        public int JudokaId { get; }
    }
}
