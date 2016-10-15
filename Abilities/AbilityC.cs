namespace GameProject
{
    class AbilityC : Ability
    {
        public AbilityC(long cd, long toa, int mc, CastType ct, int[] mod) : base(cd, toa, mc, ct, mod)
        {

        }

        protected override void AreaAction(ref ICharacter c)
        {
            if (Point.IsPointInsideCircle(c.characteristicsHistory.Peek().CurrentLocation, this.TargetCoordinates, this.Radius))
            {

            }      
        }
    }
}
