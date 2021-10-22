using Remediation.Entities;
using Remediation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remediation.Factories
{
    public interface IMobilier
    {
        public IChair CreateChair();

        public ISofa CreateSofa();
    }
}
