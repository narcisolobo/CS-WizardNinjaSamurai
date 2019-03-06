using System;

namespace WizardNinjaSamurai {
    public class Ninja : Human {
        // Ninja should have a default dexterity of 175
        public Ninja (string name) : base (name) {
            Name = name;
            Dexterity = 175;
        }
        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack (Human target) {
            Random rand = new Random();
            int critChance = rand.Next(0,100);
            int dmg = 0;
            if (critChance <= 20) {
                dmg = 10 + (Dexterity * 5);
            }
            else {
                dmg = Dexterity * 5;
            }
            target.Health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public int Steal (Human target) {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine ($"{Name} has stolen 5 hp from {target.Name}!");
            return target.Health;
        }
    }
}