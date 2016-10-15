using System.Collections.Generic;

namespace GameProject
{
    public abstract class ICharacter
    {
        public Stack<Characteristics> characteristicsHistory { get; set; }
        public Characteristics startCharacteristics { get; set; }

        public string GetCharacteristics()
        {
            return characteristicsHistory.Count != 0 ? characteristicsHistory.Peek().ToString() : startCharacteristics.ToString();
        }

        public abstract void Cast(string castName, params ICharacter[] characters);
    }
}
