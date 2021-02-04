using System;
using System.Collections;
using System.Collections.Generic;


namespace test1
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Vasia", 20);
            Person p2 = new Person("Petia", 30);

            Group gr = new Group("205");
            gr.Add(p1);
            gr.Add(p2);
            gr.Remove(new Person("Vasia", 20));



            gr.Display();


            Console.ReadKey();
        }
    }

    



}
