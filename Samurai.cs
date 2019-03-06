using System;

namespace WizardNinjaSamurai {
    public class Samurai : Human {
        
        //  Samurai should have a default health of 200

        public Samurai (string name) : base (name) {
            Name = name;
            health = 200;
        }
        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
        public override int Attack (Human target) {
            base.Attack(target);
            if (target.Health < 50) {
                target.Health = 0;
            }
            return target.Health;
        }
        // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public int Meditate () {
            Health = 200;
            Console.WriteLine ($"{Name} has recovered 200 hp!");
            return Health;
        }
    }
}