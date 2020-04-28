using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Person.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string ALL
        {
            get
            {
                return ToString();
            }
        }

        public Person()
        {
            Name = "Test";
            LastName = "Test32";
            Weight = 1;
            Age = 1;
        }


        public Person(string tmp_name, string tmp_lastName, int tmp_weight, int tmp_age)
        {
            Name = tmp_name;
            LastName = tmp_lastName;
            Weight = tmp_weight;
            Age = tmp_age;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, weight: {Weight}kg, age: {Age}";
        }
    }
}
