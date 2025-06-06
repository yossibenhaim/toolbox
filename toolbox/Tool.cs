﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    public abstract class Tool
    {
        protected Tool(string name, int weight, string toolCategory) { }

        public abstract void Describe();

        public abstract void Use();

        public abstract string returnCategory();

        public abstract void counting();

        public abstract int ReturnCount();

        public abstract string ReturnName();
    }
}
