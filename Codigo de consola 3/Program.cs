using System;

namespace Codigo_de_consola_3
{
    class Program
    {
        static void Main(string[] args)
        {
            principal();

        }

        static void principal()
        {
            int repetir_menu;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Estructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = Int32.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }


        }


        static void opciones()
        {

            int opcion;


            System.Console.WriteLine("Ejemplos de estructuras de control");
            System.Console.WriteLine("1. Programa 1_ejemplo_If");
            System.Console.WriteLine("2. Programa 2_ejemplo_While");
            System.Console.WriteLine("3. Programa 3_ejemplo_Do-While");
            System.Console.WriteLine("4. Programa 4_ejemplo_For");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Programa1_ejemplo_If();
                    break;
                case 2:
                    Programa2_ejemplo_While();
                    break;
                case 3:
                    Programa3_ejemplo_DoWhile();
                    break;
                case 4:
                    Programa4_ejemplo_For();
                    break;
                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }
            System.Console.ReadKey();
            principal();

        }

        static void Programa1_ejemplo_If()


        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            System.Console.WriteLine("Ejemplo de IF");
            Console.WriteLine("ingrese un numero entre 1 y 3");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("valor es 1");
            }
            else
            if (num == 2)
            {
                Console.WriteLine("valor es 2");
            }
            else
            if (num == 3)
            {
                Console.WriteLine("valor es 3");
            }
            else
            {
                Console.WriteLine("no se encontro el valor");
            }
            Console.ReadKey();

        }

        static void Programa2_ejemplo_While()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            System.Console.WriteLine("Ejemplo de sentencia while");

            //imprimira los números multiples de 3 del 0 al 50.

            int numero = 0;

            while (numero <= 50)
            {
                if (numero % 3 == 0)
                {
                    System.Console.WriteLine(numero);
                }
                numero++;
            }
            Console.ReadKey();
        }



        static void Programa3_ejemplo_DoWhile()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            System.Console.WriteLine("Ejemplo Do-while");

            int numero = 0;
            //se introducira un número y el ciclo se dentendra hasta que el número ingresado sea 0
            do
            {
                System.Console.WriteLine("Ingrese un número");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero != 0);

            Console.ReadKey();
        }


        static void Programa4_ejemplo_For()
        {
            //según el numero se representara en una pirámide de asteriscos.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Ejemplo de ciclo For");
            System.Console.WriteLine("Ingrese un número y se pintara una pirámide con esos escalones.");

            int numero = Convert.ToInt32(Console.ReadLine());

            for (int contador = 0; contador <= numero; contador++)
            {
                for (int asteriscos = 1; asteriscos <= contador; asteriscos++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();
        }


    }
}
   
