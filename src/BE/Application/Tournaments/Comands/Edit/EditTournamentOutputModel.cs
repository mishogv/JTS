using System;

namespace JTSystem.Application.Tournaments.Comands.Edit
{
    public class EditTournamentOutputModel
    {
        public EditTournamentOutputModel(int id, int winPrize, string location, DateTime startDate, DateTime endDate)
        {
            this.Id = id;
            this.WinPrize = winPrize;
            this.Location = location;
            this.startDate = startDate;
            this.endDate = endDate;;
        }

        public int Id { get; }

        public int WinPrize { get; }

        public string Location { get; }

        public DateTime startDate { get; }

        public DateTime endDate { get; }
    }
}
