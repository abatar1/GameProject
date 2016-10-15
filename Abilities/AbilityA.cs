namespace GameProject.Abilities
{
    class AbilityA : Ability
    {
        public AbilityA(long cd, long toa, int mc, CastType ct, int[] mod) : base(cd, toa, mc, ct, mod)
        {

        }

        protected override void TemporaryAction(ref ICharacter c)
        {

        }
    }
}
