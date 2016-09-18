namespace EnergonSoftware.FauxCompanion.Models
{
    public sealed class FauxTotemModelCharacteristic
    {
        public string Restriction { get; set; } = string.Empty;

        public bool IsAllowed(string modelName)
        {
            return string.IsNullOrWhiteSpace(Restriction) || Restriction.Equals(modelName);
        }
    }
}
