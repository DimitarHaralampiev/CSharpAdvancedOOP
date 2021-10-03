using MilitaryElite.Contracts;

namespace MilitaryElite.Soldiers.Models
{
    public class Soldier : ISoldier
    {
        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }
    }
}
