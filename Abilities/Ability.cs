namespace GameProject
{
    public abstract class Ability : IAbility
    {
        public long Cooldown { get; set; }
        public long TimeOfAction { get; set; }
        public int ManaCost { get; set; }
        public CastType CastType { get; set; }
        public int[] Modifiers { get; set; }
        public Point TargetCoordinates { get; set; }
        public double Radius { get; set; }

        public Ability(long cd, long toa, int mc, CastType ct, int[] mod)
        {
            Cooldown = cd;
            TimeOfAction = toa;
            ManaCost = mc;
            CastType = ct;
            Modifiers = mod;
        }

        public void Action(ref ICharacter c)
        {
            if (CastType == CastType.Temporary)
                TemporaryAction(ref c);
            else if (CastType == CastType.Permanent)
                PermanentAction(ref c);
            else if (CastType == CastType.Area)
                AreaAction(ref c);
        }

        protected virtual void TemporaryAction(ref ICharacter c)
        {

        }

        protected virtual void PermanentAction(ref ICharacter c)
        {

        }

        protected virtual void AreaAction(ref ICharacter c)
        {

        }
    }

}
