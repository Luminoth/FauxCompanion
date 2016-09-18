using System;

using EnergonSoftware.FauxCompanion.Core.Util;

namespace EnergonSoftware.FauxCompanion
{
    [Flags]
    public enum FauxFaction
    {
        [Description("None")]
        None = 0,

        [Description("Arcanists")]
        Arcanists = 1 << 0,

        [Description("Gremlins")]
        Gremlins = 1 << 1,

        [Description("Guild")]
        Guild = 1 << 2,

        [Description("Neverborn")]
        Neverborn = 1 << 3,

        [Description("Outcasts")]
        Outcasts = 1 << 4,

        [Description("Resurrectionists")]
        Resurrectionists = 1 << 5,

        [Description("Ten Thunders")]
        TenThunders = 1 << 6
    }
}
