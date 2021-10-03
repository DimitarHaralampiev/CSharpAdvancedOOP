using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Commando : ICommando, ISpecialisedSoldier
    {
        public ICollection<Mission> Mission { get; }

        public SoldierEnumCorp Corp { get; }
    }
}
