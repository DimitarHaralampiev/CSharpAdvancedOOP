using MilitaryElite.Contracts;
using MilitaryElite.Enumerations;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public string CodeName { get; }

        public ComandoEnumState State { get; protected set; }

        public void CompleteMission()
        {
            this.State = ComandoEnumState.Finished;
        }
    }
}
