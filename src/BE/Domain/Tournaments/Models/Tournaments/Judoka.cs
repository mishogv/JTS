namespace JTSystem.Domain.Tournaments.Models.Tournaments
{
    using Common.Models;
    using JTSystem.Domain.Tournaments.Events;

    public class Judoka : Entity<int>
    {
        public Judoka(string name, Category category, int wins, int loses)
        {
            this.Name = name;
            this.Category = category;
            this.Wins = wins;
            this.Loses = loses;
        }

        private Judoka()
        {
            this.Name = default!;
            this.Category = default!;
        }

        public string Name { get; private set; }

        public Category Category { get; private set; }

        public int Wins { get; private set; }

        public int Loses { get; private set; }

        public void UpdateJudoka(string name, Category category, int wins, int loses)
        {
            // TODO : Validate
            this.Name = name;
            this.Category = category;
            this.Wins = wins;
            this.Loses = loses;
        }

        public void RaiseJudokaViewedEvent()
        {
            this.RaiseEvent(new JudokaViewedEvent(this.Id));
        }
    }
}
