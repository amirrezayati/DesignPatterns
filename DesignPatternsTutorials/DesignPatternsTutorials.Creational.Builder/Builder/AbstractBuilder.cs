using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTutorials.Creational.Builder.Builder
{
    public abstract class AbstractBuilder
    {
        protected Product.ProductBuilder ProductBuilder;

        protected AbstractBuilder()
        {
            ProductBuilder = new Product.ProductBuilder();
        }

        public abstract void BuildPartOne();
        public abstract void BuildPartTwo();

        public virtual Product.ProductBuilder GetResult()
        {
            return ProductBuilder;
        }
    }
}
