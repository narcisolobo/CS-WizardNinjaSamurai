using System;

namespace WizardNinjaSamurai {
    public class Wizard : Human {
        // Wizard should have a default health of 50 and Intelligence of 25

        public Wizard (string name) : base (name) {
            Name = name;
            Intelligence = 25;
            health = 50;
        }
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack (Human target) {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            health += dmg;
            return target.Health;
        }
        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal (Human target) {
            int cure = Intelligence * 10;
            target.Health += cure;
            Console.WriteLine ($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }
    }
}