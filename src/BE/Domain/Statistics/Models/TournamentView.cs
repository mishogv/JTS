namespace JTSystem.Domain.Statistics.Models
{
    using JTSystem.Domain.Common.Models;
    using System;

    public class TournamentView : Entity<int>
    {
        internal TournamentView(int tournamentId)
        {
            this.TournamentId = tournamentId;
            this.When = DateTime.UtcNow;
        }

        public int TournamentId { get; }

        public DateTime When { get; }
    }
}
