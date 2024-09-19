using System;
using CsharpEstructuras;

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

            bool myBool = false;
            System.Console.WriteLine(myBool);

            System.Console.WriteLine($"El valor de mi entero es {myInt} y mi bool es {myBool}");

            const string MyConst = "Mi Constante";
            System.Console.WriteLine(MyConst);

            // Estructuras

            var myArray = new string[] { "Mohamed", "El Kasmi" };
            System.Console.WriteLine(myArray);

            // Todas as variables básicas:
            int entero = 10;
            double decimalGrande = 9.99;
            float decimalPequeño = 3.14f;
            char caracter = 'M';
            string texto = "Hola";
            bool esVerdadero = true;

            Console.WriteLine(entero);
            Console.WriteLine(decimalGrande);
            Console.WriteLine(decimalPequeño);
            Console.WriteLine(caracter);
            Console.WriteLine(texto);
            Console.WriteLine(esVerdadero);

            Estructuras es= new Estructuras();
            es.condicionales;

        }
    }
}