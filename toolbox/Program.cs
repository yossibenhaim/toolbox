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
            ToolBox toolBox = new ToolBox();

            Hammer hammer = new Hammer("hammer",4, "Fastening Tools");
            Wrench wrench = new Wrench("wrench",3, "Wrenching Tools");
            Drill drill = new Drill("drill",6, "Drilling Tools");
            Saw saw = new Saw("saw",7, "Cutting Tools");
            Screwdriver screwdriver = new Screwdriver("screwdriver",10, "Fastening Tools");
            PipeCutter pipecutter = new PipeCutter("pipecutter",8, "Cutting Tools");
            WireStripper wirestripper = new WireStripper("wirestripper", 7, "Electrical Tools");
            NailGun nailgun = new NailGun("nailgun", 1, "Fastening Tools");
            List<Tool> myTools = new List<Tool> { hammer, wrench, drill, saw, screwdriver, pipecutter, wirestripper, nailgun };

                       
            foreach (Tool tool in myTools)
            {
                toolBox.AddTool(tool);
            }

            toolBox.PrintToolInformation();
            toolBox.PrintAllTools();
        }
    }
}
