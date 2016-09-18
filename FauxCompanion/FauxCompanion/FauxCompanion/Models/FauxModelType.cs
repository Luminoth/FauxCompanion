using EnergonSoftware.FauxCompanion.Core.Util;

namespace EnergonSoftware.FauxCompanion.Models
{
    public enum FauxModelType
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

    public interface IFauxModelType
    {
        int MaxUpgrades { get; }

        bool CanBeLeader { get; }
    }

    public sealed class FauxModelTypeMaster : IFauxModelType
    {
        public int MaxUpgrades => 3;

        public bool CanBeLeader => true;

        public int Cache { get; set; }
    }

    public sealed class FauxModelTypeHenchman : IFauxModelType
    {
        public int MaxUpgrades => 2;

        public bool CanBeLeader => true;

        public int Cost { get; set; }

        public int Cache { get; set; }
    }

    public sealed class FauxModelTypeEnforcer : IFauxModelType
    {
        public int MaxUpgrades => 1;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }

    public sealed class FauxModelTypeMinion : IFauxModelType
    {
        public int MaxUpgrades => 0;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }

    public sealed class FauxModelTypePeon : IFauxModelType
    {
        public int MaxUpgrades => 0;

        public bool CanBeLeader => false;

        public int Cost { get; set; }
    }
}
