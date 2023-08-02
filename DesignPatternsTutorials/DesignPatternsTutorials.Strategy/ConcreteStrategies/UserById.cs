using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Strategy.Entities;

namespace DesignPatternsTutorials.Strategy.ConcreteStrategies
{
    public class UserById : IComparer<UserEntity>
    {
        public int Compare(UserEntity x, UserEntity y)
        {
            if (x.Id > y.Id)
                return 1;

            if (x.Id < y.Id)
                return -1;

            return 0;
        }
    }

    public class UserByAge : IComparer<UserEntity>
    {
        public int Compare(UserEntity x, UserEntity y)
        {
            if (x.Age > y.Age)
                return 1;

            if (x.Age < y.Age)
                return -1;

            return 0;
        }
    }
}
