using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace toolbox
{
    internal class ToolBox
    {
        private List<Tool> _tools = new List<Tool>();

        public void AddTool(Tool tool)
        {
            _tools.Add(tool);
        }

        public void PrintAllTools()
        {
            var counts = _tools.GroupBy(item => item.returnCategory()); 

            foreach (var group in counts)
            {
                Console.WriteLine($"{group.Key} appears {group.Count()} times");
            }

        }

        public void PrintToolInformation()
        {
            foreach (Tool tool in _tools)
            {
                tool.Describe();
            }
        }


    }
}
