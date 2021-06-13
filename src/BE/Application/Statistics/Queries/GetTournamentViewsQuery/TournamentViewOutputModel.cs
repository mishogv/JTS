namespace JTSystem.Application.Statistics.Queries.GetTournamentViewsQuery
{
    using System;

    public class TournamentViewOutputModel
    {
        public TournamentViewOutputModel(int tournamentId, DateTime when)
        {
            this.TournamentId = tournamentId;
            this.When = when;
        }

        public int TournamentId { get; }

        public DateTime When { get; }
    }
}
