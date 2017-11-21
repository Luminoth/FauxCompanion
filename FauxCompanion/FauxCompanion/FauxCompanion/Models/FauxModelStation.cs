using EnergonSoftware.FauxCompanion.Core.Util;

namespace EnergonSoftware.FauxCompanion.Models
{
// TODO: this might make more sense as StationCharacteristic or Rank

    public enum FauxModelStation
    {
        [Description("Master")]
        Master,

        [Description("Henchman")]
        Henchman,

        [Description("Enforcer")]
        Enforcer,

        [Description("Minion")]
        Minion,

        [Description("Peon")]
        Peon
    }

    public interface IFauxModelStation
    {
        int MaxUpgrades { get; }

        bool CanBeLeader { get; }
    }

    public static class FauxModelStationFactory
    {
        public static IFauxModelStation Create(FauxModelStation modelStation)
        {
            switch(modelStation)
            {
            case FauxModelStation.Master:
                return new FauxModelStationMaster();
            case FauxModelStation.Henchman:
                return new FauxModelStationHenchman();
            case FauxModelStation.Enforcer:
                return new FauxModelStationEnforcer();
            case FauxModelStation.Minion:
                return new FauxModelStationMinion();
            case FauxModelStation.Peon:
                return new FauxModelStationPeon();
            default:
                return null;
            }
        }
    }

    public sealed class FauxModelStationMaster : IFauxModelStation
    {
        public int MaxUpgrades => 3;

        public bool CanBeLeader => true;

        public int Cache { get; set; }
    }

    public sealed class FauxModelStationHenchman : IFauxModelStation
    {
        public int MaxUpgrades => 2;

        public bool CanBeLeader => true;

        public int Cost { get; set; }

        public int Cache { get; set; }
    }

    public sealed class FauxModelStationEnforcer : IFauxModelStation
    {
        public int MaxUpgrades => 1;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }

    public sealed class FauxModelStationMinion : IFauxModelStation
    {
        public int MaxUpgrades => 0;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }

    public sealed class FauxModelStationPeon : IFauxModelStation
    {
        public int MaxUpgrades => 0;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }
}
