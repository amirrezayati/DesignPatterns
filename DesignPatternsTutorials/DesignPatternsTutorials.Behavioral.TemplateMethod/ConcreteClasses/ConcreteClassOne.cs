using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Behavioral.TemplateMethod.AbstractClasses;

namespace DesignPatternsTutorials.Behavioral.TemplateMethod.ConcreteClasses
{
    public class ConcreteClassOne : AbstractClassTemplateMethod
    {
        protected override void PrimitiveOperationOne()
        {
            Console.WriteLine("PrimitiveOperationOne End");
        }

        protected override void PrimitiveOperationTwo()
        {
            Console.WriteLine("PrimitiveOperationTwo End");
        }
    }
}
