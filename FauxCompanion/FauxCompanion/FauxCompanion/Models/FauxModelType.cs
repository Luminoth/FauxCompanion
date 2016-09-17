namespace EnergonSoftware.FauxCompanion.Models
{
    public interface IFauxModelType
    {
        int MaxUpgrades { get; }
    }

    public sealed class FauxModelTypeMaster : IFauxModelType
    {
        public int MaxUpgrades => 3;

        public int Cache { get; private set; }
    }

    public sealed class FauxModelTypeHenchman : IFauxModelType
    {
        public int MaxUpgrades => 2;

        public int Cost { get; private set; }

        public int Cache { get; private set; }
    }

    public sealed class FauxModelTypeEnforcer : IFauxModelType
    {
        public int MaxUpgrades => 1;

        public int Cost { get; private set; }
    }

    public sealed class FauxModelTypeMinion : IFauxModelType
    {
        public int MaxUpgrades => 0;

        public int Cost { get; private set; }
    }

    public sealed class FauxModelTypePeon : IFauxModelType
    {
        public int MaxUpgrades => 0;

        public int Cost { get; private set; }
    }
}
