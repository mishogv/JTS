namespace JTSystem.Application.Tournaments.Queries.Details
{
    using JTSystem.Application.Tournaments.Queries.Common;
    using System;
    using System.Collections.Generic;

    public class TournamentDetailsOutputModel : TournamentOutputModel
    {
        public TournamentDetailsOutputModel(int id, string name, int winPrize, string location, DateTime startDate, DateTime endDate, ICollection<CategoryOutputModel> categories, ICollection<JudokaOutputModel> judokas)
            : base(id, name, winPrize, location, startDate, endDate)
        {
            this.Categories = categories;
            this.Judokas = judokas;
        }

        public ICollection<CategoryOutputModel> Categories { get; }

        public ICollection<JudokaOutputModel> Judokas { get; }
    }
}
