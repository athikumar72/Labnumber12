using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
    class TheJets : Player
    {
        
        public override Roshambo generateRoshambo(Roshambo value)
        {
            return Roshambo.rock;
        }

        public override void generateRoshambo()
        {
            Console.WriteLine("");
        }

    }
    }

    
 