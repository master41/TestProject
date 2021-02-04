using System;
using System.Collections.Generic;
namespace test1
{
    class Person 
    {
        private string _name;
        private int _age;




        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return $"{_name} {_age}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   _name == other._name &&
                   _age == other._age;
        }

        public override int GetHashCode()
        {
            int hashCode = 1700751558;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + _age.GetHashCode();
            return hashCode;
        }



        //public static bool operator ==(Person left, Person right)
        //{
        //    return EqualityComparer<Person>.Default.Equals(left, right);
        //}

        //public static bool operator !=(Person left, Person right)
        //{
        //    return !(left == right);
        //}
    }
}
