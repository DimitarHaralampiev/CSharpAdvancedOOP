using MilitaryElite.Contracts;
using MilitaryElite.Soldiers.Models;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; }
    }
}
