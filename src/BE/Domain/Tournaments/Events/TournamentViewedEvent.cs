namespace JTSystem.Domain.Tournaments.Events
{
    using JTSystem.Domain.Common;

    public class TournamentViewedEvent : IDomainEvent
    {
        internal TournamentViewedEvent(int tournamentId)
        {
            this.TournamentId = tournamentId;
        }

        public int TournamentId { get; }
    }
}
