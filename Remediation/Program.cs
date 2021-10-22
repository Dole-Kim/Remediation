using Remediation.Factories;
using System;

namespace Remediation
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ModernFactory();

            factory.CreateChair();
            factory.CreateSofa();
        }
    }
}
