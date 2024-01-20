using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_Hongfei
{
    public class Person
    {
        //Add field 
        private string name;
        private int age;
        private int id;

        public string Name { get => name; set => name=value; }
        public int Age { get => age; set => age=value; }
        public int Id { get => id; set => id=value; }

        //Constructor,use 'this' to distinguish fields from parameters
        public Person(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id=id;
        }

        //Overloaded constructor
        public Person(string name)
        {
            this.name = name;
        }

        //Method to display the person information

        public void Display()
        {
            Console.WriteLine($" Name: {this.name}, Age: {this.age}, ID: {this.id}");
        }

        //Method to updated the person'age
        public void SetAgeandID(int age,int id)
        {
            this.age = age;
            this.id = id;
        }

    }
}
