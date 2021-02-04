using System;
using System.Collections.Generic;

namespace test1
{
    class Group
    {
        private string _name;
        private List<Person> _persons;

        public Group(string name)
        {
            _name = name;
            _persons = new List<Person>();
        }

        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public void Display()
        {
            foreach (var item in _persons)
            {
                Console.WriteLine(item);
            }
        }

        public void Remove(Person person)
        {
            _persons.Remove(person);
        }
    }
}
