using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Behavioral.TemplateMethod.AbstractClasses;

namespace DesignPatternsTutorials.Behavioral.TemplateMethod
{
    public class Client
    {
        public static void Run(AbstractClassTemplateMethod method)
        {
            method.TemplateOperation();
        }
    }
}
