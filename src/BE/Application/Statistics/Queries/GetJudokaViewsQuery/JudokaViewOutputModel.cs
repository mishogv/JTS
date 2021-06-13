namespace JTSystem.Application.Statistics.Queries.GetJudokaViewsQuery
{
    using System;

    public class JudokaViewOutputModel
    {
        public JudokaViewOutputModel(int judokaId, DateTime when)
        {
            this.JudokaId = judokaId;
            this.When = when;
        }

        public int JudokaId { get; }

        public DateTime When { get; }
    }
}
