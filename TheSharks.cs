using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
    class TheSharks : Player

    {
        int randomValue = 0;
        public override Roshambo generateRoshambo(Roshambo value)
        {
            Random value1 = new Random();
            randomValue = value1.Next(1, 4);
            switch (randomValue)
            {
                case 1:
                    return roshamboValue = Roshambo.rock;
                case 2:
                    return roshamboValue = Roshambo.paper;
                case 3:
                    return roshamboValue = Roshambo.scissor;
               default:
                    return Roshambo.none;

            }
        }

    public override void generateRoshambo()
        {
            Console.WriteLine("");
        }

                }
    }


