﻿namespace Delta.Trinity.Hotfixes
{
    public partial class SpellDuration
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public int MaxDuration { get; set; }
        public int DurationPerLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
