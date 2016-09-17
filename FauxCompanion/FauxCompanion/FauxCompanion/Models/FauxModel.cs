using System.Collections.Generic;

using EnergonSoftware.FauxCompanion.Characteristics;
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

        public string Name { get; private set; }

        public FauxFaction Faction { get; private set; }

        public IFauxModelType ModelType { get; private set; }

        public BaseSize Size { get; private set; }

        private readonly List<FauxModelCharacteristic> _characteristics = new List<FauxModelCharacteristic>();

        public FauxModel(string name, FauxFaction faction, IFauxModelType modelType, BaseSize baseSize)
        {
            Name = name;
            Faction = faction;
            ModelType = modelType;
            Size = baseSize;
        }
    }
}
