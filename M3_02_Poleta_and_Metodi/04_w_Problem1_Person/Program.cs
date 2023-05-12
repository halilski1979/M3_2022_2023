using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_w_Problem1_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ivan";
            p.Age = 23;

            p.IntroduceYourSelf();

        }
    }
}
