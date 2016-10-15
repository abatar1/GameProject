namespace GameProject
{
    class AbilityB : Ability
    {
        public AbilityB(long cd, long toa, int mc, CastType ct, int[] mod) : base(cd, toa, mc, ct, mod)
        {

        }

        protected override void PermanentAction(ref ICharacter c)
        {

        }
    }
}
