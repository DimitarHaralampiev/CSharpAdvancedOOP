
using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Engineer : IEngineer, ISpecialisedSoldier
    {
        public ICollection<IRepair> Repairs { get; }

        public SoldierEnumCorp Corp { get; }
    }
}
