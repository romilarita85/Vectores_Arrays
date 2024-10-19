namespace Clase17_10_ArrayDeChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PROBLEMA DE CONVERCION
            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = lectura;//->No se puede con hacer esa convercion
            //variable de tipo string no se puede guardar en una variable tipo array de caracteres
            #endregion

            //CONVERTIR "lectura" EN UN ARRAY DE CHAR:
            //FORMAS DE CARGAR ARRAY DE LO Q INGRESE EL USUARIO POR CONSOLA***********
            #region 1-USANDO METODO ToCharArray():
            //(saca letra por letra de lo q tengo adentro de la variable "lectura" y pasarsela a cada posicion del array)

            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = lectura.ToCharArray(); //->array definido en la misma linea
            #endregion
            #region 2-CREANDO UN ARRAY DINAMICO -CANTIDAD DE ESPACIOS DIMENCION DEFINIDA
            //Array con las dimenciones q tiene lectura
            //no se el tamaño q va a tener mi array

            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = new char[lectura.Length];//->dimencion definida(calculando largo del array)
            #endregion
            #region 3-DIMENCION DEFINIDA + FOR

            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = new char[lectura.Length];
            //Console.WriteLine($"Contenido de la var lectura: {lectura}");
            //for (int i = 0; i < lectura.Length; i++)
            //{
            //    letras[i] = lectura[i];
            //    //Mi array de letras en la posicion de i va a ser igual a
            //    mi array de caracteres ->lectura(puedo acceder a las posiciones de cada letra)
            //    //voy a sacar el valor que tenga letras en cada posicion de i
            //}
            //Console.WriteLine("Contenido del array");
            //foreach (char item in letras) // para recorrer
            //{
            //    Console.WriteLine(item);    
            //}
            #endregion

            #region USANDO METODO TO CHAR ARRAY:*********************************************
            //no tengo q calcular el largo del array 
            //hace lo mismo q forma 2 (lectura.Length)
            //Agarra el largo del string lo recorre de punta a punta saca letra a letra
            //y la va asignando en la posicion q tiene cada una de las vocales o consonantes
            //q tenga mi palabra de tipo string
            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = lectura.ToCharArray();
            //Console.WriteLine($"Contenido de la var lectura: {lectura}");

            //Console.WriteLine("Contenido del array");
            //foreach (char item in letras) // para recorrer
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ORDENAMIENTO DE ARRAY(VECTOR) DE CHAR:************

            //for (int i = 0; i < letras.Length; i++)
            //{
            //    for (int j = i+1; j < letras.Length; j++)
            //    {
            //        if (letras[i] > letras[j])
            //        {
            //            char auxiliar = letras[i];
            //            letras[i] = letras[j];
            //            letras[j] = auxiliar;

            //        }
            //    }
            //}
            #endregion
            
            //MOSTRAR CON FOR O FOREACH ***********************
            string lectura;
            Console.Write("Ingrese una palabra: ");
            lectura = Console.ReadLine();

            char[] letras = lectura.ToCharArray();
            Console.WriteLine($"Contenido de la var lectura: {lectura}");

            Console.WriteLine("Contenido del array");
            //FOR PARA MOSTRAR
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i]);//write:en una sola linea

            }
            //FOREACH PARA MOSTRAR
            foreach (char item in letras) // para recorrer
            {
                Console.WriteLine(item);//writeline: una letra abajo de la otra
            }
            //MOSTRAR EN REVERSA:*********************************
            for (int i = letras.Length -1; i >=0; i--)
            {
                Console.Write(letras[i]);//Write:en una sola linea
            }
        }
    }
}
