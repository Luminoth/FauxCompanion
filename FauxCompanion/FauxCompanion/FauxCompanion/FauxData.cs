using System.Collections.Generic;

using EnergonSoftware.FauxCompanion.Models;
using EnergonSoftware.FauxCompanion.Upgrades;

using Newtonsoft.Json;

namespace EnergonSoftware.FauxCompanion
{
    public sealed class FauxData
    {
        public static FauxData Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<FauxData>(json);
        }

        public static string Serialize(FauxData fauxData)
        {
            return JsonConvert.SerializeObject(fauxData);
        }

        private readonly List<FauxModel> _models = new List<FauxModel>();

        private readonly List<FauxUpgrade> _upgrades = new List<FauxUpgrade>();
    }
}
