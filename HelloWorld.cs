using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hola mundo
            Console.WriteLine("Hello, CSharp!");
            /*
            Hola a todos esto es un comentario
            */

            string myString = "Hola a todos";
            myString = "Cambio de valor";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt + 33;
            Console.WriteLine(myInt);

            double myDouble = 30;
            System.Console.WriteLine(myDouble);

            float myFloat = 4.3f;
            System.Console.WriteLine(myFloat);

            dynamic myDynamic = 6;
            myDynamic = "Hola que tal he cambiado este dato";
            System.Console.WriteLine(myDynamic);


        }
    }
}