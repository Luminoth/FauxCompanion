using System;

namespace EnergonSoftware.FauxCompanion.Models
{
    [Flags]
    public enum FauxModelCharacteristic : long
    {
        None = 0,

        // Creature Characteristics
        Construct = 1 << 0,
        Living = 1 << 1,
        Undead = 1 << 2,

        TriChi = 1 << 3,
        Unhirable = 1 << 4,
    }
}
