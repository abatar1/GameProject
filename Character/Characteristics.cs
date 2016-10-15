using System;

namespace GameProject
{
    public class Characteristics
    {
        private int HitPoints;
        private int ManaPoints;
        private double MovementSpeed;
        private double ManaRegeneration;
        public Point CurrentLocation;

        public Characteristics(object[] mods)
        {
            HitPoints = (int)mods[0];
            ManaPoints = (int)mods[1];
            MovementSpeed = (double)mods[2];
            ManaRegeneration = (double)mods[3];
            CurrentLocation = (Point)mods[4];
        }

        public void Modify(object[] mods)
        {
            try
            {
                HitPoints += (int)mods[0];
                ManaPoints += (int)mods[1];
                MovementSpeed += (double)mods[2];
                ManaRegeneration += (double)mods[3];
                CurrentLocation += (Point)mods[4];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return "HP: " + HitPoints.ToString() +
                "MP: " + ManaPoints.ToString() +
                "MS: " + MovementSpeed.ToString() +
                "MR: " + ManaRegeneration.ToString();
        }
    }
}
