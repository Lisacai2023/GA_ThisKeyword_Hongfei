using System;

namespace GA_ThisKeyword_Hongfei
{
    //Week2_GA_ThisKeyword
    //Hongfei_C
    //01/19/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sam", 10, 1001);
            person1.Display();

            Person person2 = new Person("Tina");
            person2.Display();
            person2.SetAgeandID(5,1002);
            person2.Display();
            Person person3 = person2;
            person3.Name = "Laura";
            person3.Id = 1003;
            person3.Display();

            Console.ReadKey();

        }
    }
}
