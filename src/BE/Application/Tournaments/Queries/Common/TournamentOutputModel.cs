namespace JTSystem.Application.Tournaments.Queries.Common
{
    using System;

    public class TournamentOutputModel
    {
        public TournamentOutputModel(int id, string name, int winPrize, string location, DateTime startDate, DateTime endDate)
        {
            this.Id = id;
            this.Name = name;
            this.WinPrize = winPrize;
            this.Location = location;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public int Id { get; }

        public string Name { get; }

        public int WinPrize { get; }

        public string Location { get; }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }
    }
}
