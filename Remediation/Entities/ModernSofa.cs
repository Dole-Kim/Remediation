using Remediation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remediation.Entities
{
    public class ModernSofa : ISofa
    {
        public ModernSofa()
        {
            Console.WriteLine("j'ai contruit un sofa moderne");
        }
    }
}
