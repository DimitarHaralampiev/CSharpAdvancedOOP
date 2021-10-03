using MilitaryElite.Contracts;
using MilitaryElite.Soldiers.Models;

namespace MilitaryElite.Privates.Models
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; }
    }
}
