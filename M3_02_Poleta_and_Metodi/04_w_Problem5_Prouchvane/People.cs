using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_w_Problem5_Prouchvane
{
    public class People
    {
        private List<Person> persons = new List<Person>();

        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public void AddPerson(Person member)
        {
            persons.Add(member);
        }

        public void SortName_Above30()
        {
            var result = persons.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
