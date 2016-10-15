using System.Collections.Generic;
using System.Linq;

namespace GameProject
{
    public abstract class Character : ICharacter
    {
        public readonly Dictionary<string, IAbility> abilities;
        public TimeController time;

        public override void Cast(string castName, params ICharacter[] characters)
        {
            var ability = abilities[castName];
            for (int i = 0; i < characters.Count(); i++)
            {
                var character = characters[i];
                ability.Action(ref character);
                time.AddCastTimer(castName, abilities[castName].TimeOfAction);
            }
        }
    }
}
