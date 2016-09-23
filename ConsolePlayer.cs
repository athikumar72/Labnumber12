using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
    public class ConsolePlayer : Player
    {

        public override void generateRoshambo()
        {
            Console.WriteLine("");
           }

        public override Roshambo generateRoshambo(Roshambo value)
        {
            return value;
        }
    }
}   