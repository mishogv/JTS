namespace JTSystem.Domain.Statistics.Models
{
    using JTSystem.Domain.Common;
    using System.Collections.Generic;
    using System.Linq;

    public class Statistics : IAggregateRoot
    {
        private readonly HashSet<JudokaView> judokaViews;
        private readonly HashSet<TournamentView> tournamentViews;

        public Statistics()
        {
            this.judokaViews = new HashSet<JudokaView>();
            this.tournamentViews = new HashSet<TournamentView>();
        }

        public IReadOnlyCollection<JudokaView> JudokaViews
            => this.judokaViews.ToList().AsReadOnly();

        public IReadOnlyCollection<TournamentView> TournamentViews
            => this.tournamentViews.ToList().AsReadOnly();

        public void AddJudokaView(int judokaId)
            => this.judokaViews.Add(new JudokaView(judokaId));

        public void AddTournamentView(int tournamentId)
            => this.tournamentViews.Add(new TournamentView(tournamentId));
    }
}
