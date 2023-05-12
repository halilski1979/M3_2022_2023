using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_w_Problem4_Family
{
   public class Family
    {
       private List<Person> persons = new List<Person>();

       public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public void AddMembers(Person member)
        {
            persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return persons.OrderBy(x=>x.Age).LastOrDefault();
        }

        public void SortName()
        {
           var sortNames=persons.OrderBy(x=>x.Name).ToList();
            foreach (var item in sortNames)
            {
                Console.WriteLine($"{item.Name} => {item.Age}");
            }
        }

        public void SortAge()
        {
            var sortAges = persons.OrderBy(x => x.Age).ToList();
            foreach (var item in sortAges)
            {
                Console.WriteLine($"{item.Name} => {item.Age}");
            }
        }

        public void Print()
        {
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} => {item.Age}");
            }
        }
       

    }
}
