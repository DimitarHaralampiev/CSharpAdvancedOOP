using MilitaryElite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        public string CodeName { get; }

        public ComandoEnumState State { get; }

        public void CompleteMission();
    }
}
