namespace GameProject
{
    public interface IAbility
    {
        long Cooldown { get; set; }
        long TimeOfAction { get; set; }
        int ManaCost { get; set; }
        CastType CastType { get; set; }
        int[] Modifiers { get; set; }
        Point TargetCoordinates { get; set; }
        double Radius { get; set; }

        void Action(ref ICharacter c);
    }
}
