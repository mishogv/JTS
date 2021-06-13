namespace JTSystem.Domain.Tournaments.Factories.Tournaments
{
    using JTSystem.Domain.Tournaments.Models.Tournaments;
    using System;

    public class TournamentFactory : ITournamentFactory
    {
        private string name = default!;
        private string location = default!;
        private int winPrize;
        private DateTime startDate = default!;
        private DateTime endDate = default!;

        public Tournament Build()
        {
            return new Tournament(name, winPrize,location, startDate, endDate);
        }

        public ITournamentFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ITournamentFactory WithLocation(string location)
        {
            this.location = location;
            return this;
        }


        public ITournamentFactory WithWinPrize(int winPrize)
        {
            this.winPrize = winPrize;
            return this;
        }

        public ITournamentFactory WithStartDate(DateTime startDate)
        {
            this.startDate = startDate;
            return this;
        }

        public ITournamentFactory WithEndDate(DateTime endDate)
        {
            this.endDate = endDate;
            return this;
        }
    }
}
