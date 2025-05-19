using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class NailGun : Tool
    {
        private string _name;
        private int _weight;
        public NailGun(string name, int weight) : base(name, weight)
        {
            _name = name;
            _weight = weight;
        }

        public override void Describe()
        {
            Console.WriteLine("Your tool is the NailGun.");
        }
        public override void Use()
        {
            Console.WriteLine("NailGun is being used");
        }
    }
}
