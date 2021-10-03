using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;
using MilitaryElite.Privates.Models;

namespace MilitaryElite.Models
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SoldierEnumCorp Corp { get; }
    }
}
