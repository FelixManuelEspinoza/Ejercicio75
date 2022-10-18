using System.Collections;
namespace Ejercicio75
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int numero;

            ArrayList Lista = new ArrayList();
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            while (palabra != "")
            {
                Lista.Add(palabra);
                Console.WriteLine("Ingrese la próxima palabra");
                palabra = Console.ReadLine();
            }
            Console.WriteLine("Ingrese la posición de la palabra que desea ver");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("Ingrese la posición de la palabra que desea");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("La posición no existe \n Ingrese otra posición");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
