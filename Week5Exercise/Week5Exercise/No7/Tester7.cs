using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise.No7
{
    class Tester7
    {

        static void Main(string[] args)
        {
            

            Dog dog = new Dog(26, "Milo");
            Dog dog1 = new Dog(10, "Frisky");
            Dog dog2 = new Dog(50, "Laika");

            Dog[] dogArray = new Dog[3];
            dogArray[0] = dog;
            dogArray[1] = dog1;
            dogArray[2] = dog2;

            Console.WriteLine(dogArray[2]);


        }
        
    }
}
