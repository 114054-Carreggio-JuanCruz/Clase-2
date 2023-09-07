using System.ComponentModel;

namespace estructuras
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Temperaturas temperaturas= new Temperaturas();
            FizzBuzz fizzBuzz= new FizzBuzz();
            /*Console.WriteLine("Hello, World!");
            int n1,n2,n3;
            Console.WriteLine("Ingrese un número");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número");
            n3= int.Parse(Console.ReadLine());
            if(n1>n2 &&n1>n3)
            {
                Console.WriteLine($"El numero mas grande es {n1}");
            }
            else if (n2>n3)
            {
                Console.WriteLine($"El numero mas grande es {n2}");
                
            }
            else{
                Console.WriteLine($"El numero mas grande es {n3}");
            }*/
            Console.WriteLine("""
            Que desea hacer?
            1.- Calcular temperaturas
            2.- FizzBuzz
            0.- Salir.
            """);
            int opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 0:
                    Console.WriteLine("Adios!")
                    break;
                case 1:
                    Console.WriteLine("--------------Temperaturas-------------");
                    temperaturas.Calculotemperaturas();
                    break;
                case 2:
                    Console.WriteLine("--------------FizzBuzz-------------");
                    fizzBuzz.EjecutarFizzBuzz();
                    break;
                

            }
            
            
        }
    }
}
