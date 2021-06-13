namespace JTSystem.Domain.Tournaments.Models.Tournaments
{
    using Common.Models;

    public class Gender : Enumeration
    {
        public static readonly Gender Male = new Gender(1, nameof(Male));
        public static readonly Gender Female = new Gender(2, nameof(Female));

        private Gender(int value, string name)
            : base(value, name)
        {
        }

        private Gender(int value)
                : this(value, FromValue<Gender>(value).Name)
        {
        }
    }
}
