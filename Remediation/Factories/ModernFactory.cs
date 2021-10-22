using Remediation.Entities;
using Remediation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remediation.Factories
{
    public class ModernFactory : IMobilier
    {
        public IChair CreateChair()
        {
            return new ModernChair(); 
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
