using System;

namespace EnergonSoftware.FauxCompanion.Models
{
    [Flags]
    public enum FauxModelCharacteristic : long
    {
        None = 0,
        Living = 1 << 0,
        Undead = 1 << 1,
        Construct = 1 << 2,
        TriChi = 1 << 3,
        Unhirable = 1 << 4,
    }
}
