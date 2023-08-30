using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Battle
    {
        //Start fight

        //warrior 1 attacks warrior 2 
        //warrior 2 is damaged - health decreases
        //Get attack result

        //warrior 2 attacks warrior 1 
        //warrior 1 is damaged - health decreases
        //Get attack result

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttcAmt = warriorA.Attack();
            double warBBlockAmt = warriorB.Block();

            double dmg2WarriorB = warAAttcAmt - warBBlockAmt;

            if (dmg2WarriorB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarriorB;
            }
            else dmg2WarriorB = 0;

            Console.WriteLine("{0} attacks {1} and deals {2} damage", warriorA.Name, warriorB.Name, dmg2WarriorB);
            Console.WriteLine("{0} has {1} health\n", warriorB.Name, warriorB.Health);

            if(warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorious", warriorB.Name, warriorA.Name);
                return "Game Over";
            }

            return "Next round";
        }
    }

}
