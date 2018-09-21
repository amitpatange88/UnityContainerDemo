using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerDemo
{
    public class Ford : ICar
    {
        public int mile = 0;

        public int Run()
        {
            return 
                ++mile;
        }
    }
}
