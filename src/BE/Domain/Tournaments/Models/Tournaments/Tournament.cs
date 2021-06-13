namespace JTSystem.Domain.Tournaments.Models.Tournaments
{
    using Common;
    using Common.Models;
    using JTSystem.Domain.Tournaments.Events;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tournament : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Judoka> judokas;
        private readonly HashSet<Category> categories;

        internal Tournament(string name, int winPrize, string location, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.WinPrize = winPrize;
            this.Location = location;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.judokas = new HashSet<Judoka>();
            this.categories = new HashSet<Category>();
        }

        public string Name { get; private set; }

        public int WinPrize { get; private set; }

        public string Location { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public IReadOnlyCollection<Judoka> Judokas => judokas.ToList().AsReadOnly();

        public IReadOnlyCollection<Category> Categories => categories.ToList().AsReadOnly();

        public void UpdateInfromation(string name, int winPrize, string location, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.WinPrize = winPrize;
            this.Location = location;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public void AddJudoka(Judoka judoka)
        {
            this.judokas.Add(judoka);
        }

        public void RemoveJudoka(Judoka judoka)
        {
            this.judokas.Remove(judoka);
        }

        public void AddCategory(Category category)
        {
            this.categories.Add(category);
        }

        public void RemoveCategory(Category category)
        {
            this.categories.Remove(category);
        }

        public void RaiseTournamentViewedEvent()
        {
            this.RaiseEvent(new TournamentViewedEvent(this.Id));
        }
    }
}
