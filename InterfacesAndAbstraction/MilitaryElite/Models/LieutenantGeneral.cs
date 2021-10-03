using MilitaryElite.Contracts;
using MilitaryElite.Privates.Models;
using System.Collections.Generic;

namespace MilitaryElite.LieutenantGenerals.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public ICollection<IPrivate> Private { get; }
    }
}
