using System.Collections.Generic;

using EnergonSoftware.FauxCompanion.Models;
using EnergonSoftware.FauxCompanion.Upgrades;

namespace EnergonSoftware.FauxCompanion
{
    public sealed class FauxCrew
    {
        private readonly List<FauxModel> _models = new List<FauxModel>();

        public IReadOnlyCollection<FauxModel> Models => _models;

        private readonly Dictionary<FauxModel, List<FauxUpgrade>> _upgrades = new Dictionary<FauxModel, List<FauxUpgrade>>();
    }
}
