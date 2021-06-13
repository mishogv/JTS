namespace JTSystem.Domain.Tournaments.Factories.Tournaments
{
    using Common;
    using Models.Tournaments;
    using System;

    public interface ITournamentFactory : IFactory<Tournament>
    {
        public ITournamentFactory WithName(string name);

        public ITournamentFactory WithWinPrize(int winPrize);

        public ITournamentFactory WithLocation(string location);

        public ITournamentFactory WithStartDate(DateTime startDate);

        public ITournamentFactory WithEndDate(DateTime endDate);
    }
}
