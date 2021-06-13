namespace JTSystem.Domain.Statistics.Models
{
    using JTSystem.Domain.Common.Models;
    using System;

    public class JudokaView : Entity<int>
    {
        internal JudokaView(int judokaId)
        {
            this.JudokaId = judokaId;
            this.When = DateTime.UtcNow;
        }

        public int JudokaId { get; }

        public DateTime When { get; }
    }
}
