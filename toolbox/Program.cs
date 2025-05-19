using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer("hammer",4);
            Wrench wrench = new Wrench("wrench",3);
            Drill drill = new Drill("drill",6);
            Saw saw = new Saw("saw",7);
            Screwdriver screwdriver = new Screwdriver("screwdriver",10);
            PipeCutter pipecutter = new PipeCutter("pipecutter",8);
            Tool[] myTools = { hammer, wrench, drill, saw, screwdriver, pipecutter };
            foreach (Tool tool in myTools)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}
