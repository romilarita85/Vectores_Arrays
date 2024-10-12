using System.Diagnostics.CodeAnalysis;

namespace Clase08_10_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables Escalares:
            ////Agarrar un programa q pida 5 numeros y sumarlo
            //int numero;
            //int suma = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = int.Parse(Console.ReadLine());
            //    suma = numero + suma;
            //}
            //Console.WriteLine($"La suma es: {suma}");
            //-Estos numeros no se pueden ordenar 
            //-No se pueden mostrar despues de ingresarlos
            //Por que la variable (numero) con la que trabajamos es una variable escalar
            //Variable escalar -> una variable que me permite guardar solo un valor y
            //al iterar el for guardamos otro valor y pisamos el anterior
            //En memoria no queda un registro de lo q estamos guardando.
            #endregion

            //APLICANCO VECTORES:
            #region Declaracion del vector y inicializacion:

            //int[] numeros = { 5, 9, 7 };//harcodeo el vector

            //Console.WriteLine(numeros);//numeros -> es una direccion de memoria y C# no permite
            ////mostrar direcciones de memoria
            ////{} -> indica un conjunto

            //Console.WriteLine(numeros[0]);//variable independiente
            //Console.WriteLine(numeros[1]);//
            //Console.WriteLine(numeros[2]);//
            //                              //Console.WriteLine(numeros[3]); //->FUERA DE LOS LIMITES DEL VECTOR

            ////Poder manipular cada elemento como si fuera una variable independiente
            #endregion
            #region Escalar en un for
            //Escalar en un for:*****************************************
            //Console.WriteLine("Escalar en un for:*************************");
            //int[] numeros = { 5, 9 ,7 };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            #endregion
            //**************************************************************
            //Puedo tener un for para mostrar,un for para cargar, un for para ordenar etc.

            //int [] numeros = {5,2,7,4,9,8 }; // vector harcodeado: le di valores iniciales
            
            int[] numeros = new int[10];//crear vector vacio

            CargarVector(numeros);

            //int suma = 0;
            //int sumaPares = 0;

            //Console.WriteLine(numeros.Length);
            #region Carga Secuencial de un vector:
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}
            ////Los vectores se pueden cargar de dos formas: secuencial y Aleatoria
            ////Carga Secuencial: yo voy a recorrer cada elementos y a cada elemento le doy un valor
            ////paso desde el primero hasta el ultimo elemento.
            #endregion

            //For para mostrar vector:(muestra los numeros)****************
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);//muesta la lista de numeros
            }
            #region For para la suma*************************
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    suma += numeros[i];
            //}
            //Console.WriteLine($"La suma es: {suma}");
            #endregion
            #region For para sumar todos los pares:*****************************
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[i] % 2 == 0) 
            //    {
            //        sumaPares += numeros[i];
            //    }
            //}
            //Console.WriteLine($"La suma de los numeros pares es: {sumaPares}");
            #endregion
            #region For para mostrar vector al reves
            ////Mostrar vector al reves:(de atras para adelante)**************
            //for (int i = numeros.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            #endregion
        
        }
        //Funcion para cargar un vector con numeros enteros (Carga secuencial de un vector)
        static void CargarVector(int[] numeros) 
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
        //Funcion para mostrar
        static void MostrarVector(int[] numeros) 
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);//muesta la lista de numeros
            }
        }
        //Funcion para sumar
        static void Sumar(int[] numeros) 
        {
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++) 
            {
                suma += numeros[i];
            }
        }
        //Funcion para sumar pares
        static void SumarPares(int[] numeros) 
        {
            int sumaPares = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0) 
                {
                    sumaPares += numeros[i];
                }
            }
        }
        //Funcion para mostrar vector reversa
        static void MostrarVectorReversa(int[] numeros) 
        {
            for (int i = numeros.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(numeros[i]);//muesta la lista de numeros
            }
        }
    }
}
