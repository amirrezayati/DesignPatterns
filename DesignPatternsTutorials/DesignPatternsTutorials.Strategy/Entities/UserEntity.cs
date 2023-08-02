using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTutorials.Strategy.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id = {Id} - Name = {Name} - Age = {Age}");
        }

    }
}
