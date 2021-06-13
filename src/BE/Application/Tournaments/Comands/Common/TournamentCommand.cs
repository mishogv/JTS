namespace JTSystem.Application.Tournaments.Comands.Common
{
    using JTSystem.Application.Common;
    using System;

    public abstract class TournamentCommand<TCommand> : EntityCommand<int>
        where TCommand : EntityCommand<int>
    {
        public string Name { get; set; } = default!;

        public int WinPrize { get; set; }

        public string Location { get; set; } = default!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
