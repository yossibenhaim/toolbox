using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    public abstract class Tool
    {
        public Tool(string name, int weight) { }

        public abstract void Describe();

        public virtual void Use()
        {
            Console.WriteLine("Tool is being used");
        }

    }
}
