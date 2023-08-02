using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTutorials.Behavioral.TemplateMethod.AbstractClasses
{
    public abstract class AbstractClassTemplateMethod
    {
        public void TemplateOperation()
        {
            // do Your Work
            Console.WriteLine("I do some work for all PrimitiveOperations that in TemplateOperation");

            // Call PrimitiveOperations
            Console.WriteLine("PrimitiveOperationOne Start");
            PrimitiveOperationOne();
            Console.WriteLine("PrimitiveOperationTwo Start");
            PrimitiveOperationTwo();

            // do your Work
            Console.WriteLine("I do some work for all PrimitiveOperations that in TemplateOperation");

        }

        protected abstract void PrimitiveOperationOne();
        protected abstract void PrimitiveOperationTwo();
    }
}
