using EnergonSoftware.FauxCompanion.Core.Util;

namespace EnergonSoftware.FauxCompanion.Models
{
    public sealed class FauxModel
    {
        public enum BaseSize
        {
            [Description("30mm")]
            Small,

            [Description("40mm")]
            Medium,

            [Description("50mm")]
            Large
        }

        public string Name { get; set; } = string.Empty;

        public FauxFaction Faction { get; set; } = FauxFaction.None;

        public IFauxModelType ModelType { get; set; } = new FauxModelTypeMinion();

        public BaseSize Size { get; set; } = BaseSize.Small;

        public FauxRarity Rarity { get; set; } = FauxRarity.Zero;

        private FauxModelCharacteristic _characteristics = FauxModelCharacteristic.None;

        public FauxTotemModelCharacteristic TotemCharacteristic { get; set; }

#region Characteristics
        public void AddCharacteristic(FauxModelCharacteristic characteristic)
        {
            _characteristics |= characteristic;
        }

        public bool HasCharacterisitc(FauxModelCharacteristic characteristic)
        {
            return (long)characteristic == (long)(_characteristics & characteristic);
        }
#endregion

#region Totem
        public bool IsTotem()
        {
            return null != TotemCharacteristic;
        }

        public bool IsTotemAllowed(string modelName)
        {
            return IsTotem() && TotemCharacteristic.IsAllowed(modelName);
        }
#endregion
    }
}
