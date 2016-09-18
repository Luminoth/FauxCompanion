namespace EnergonSoftware.FauxCompanion.Upgrades
{
    public sealed class FauxUpgrade
    {
        public string Name { get; set; } = string.Empty;

        public FauxFaction Faction { get; set; } = FauxFaction.None;

        public int Cost { get; set; }

        public FauxRarity Rarity { get; set; } = FauxRarity.Zero;

        public bool IsLimited { get; set; }

        private FauxUpgradeRestriction _restrictions = FauxUpgradeRestriction.None;

#region Restrictions
        public void AddRestriction(FauxUpgradeRestriction restriction)
        {
            _restrictions |= restriction;
        }

        public bool HasRestriction(FauxUpgradeRestriction restriction)
        {
            return (long)restriction == (long)(_restrictions & restriction);
        }
#endregion
    }
}
