namespace Clase10_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VECTORES NUMERICOS:
            //Si queremos agrupar toda la cantidad de datos dentro de una misma variable esa variable es un vector.
            #region FORMAS DE CREAR UN ARRAY:
            ////1)-Forma de crear Array vacio de 5 elementos:
            //int[] numeros = new int[5];

            ////2)-Forma de crar Array definiendo que valores va a tener adentro:
            //int[] numeros2 = {12,15,78,5,25 };

            ////Los arrays son inmutables: si yo le defini 5 unidades y siempre va a tener 5 unidades.
            ////puede pasar q esas unidades esten vacias.
            #endregion

            #region FORMAS DE CARGAR UN ARRAY

            //int[] numeros = new int[5];//array con 5 posiciones vacias

            /////Numeros cargados de forma aleatoria:
            ////numeros[0] = 54;
            ////numeros[1] = 82;
            ////numeros[2] = 10;
            ////numeros[3] = 52;
            ////numeros[4] = 12;

            /////Numeros cargados en forma parcial y de manera aleatoria

            //numeros[3] = 52;
            //numeros[0] = 54;

            /////No estoy obligado a darle valor a todas las posiciones
            /////podemos cargar todas las posiciones de entrada, podemos cargar algunas o salteado
            /////Las asignaciones son destructivas: siempre se queda con el ultimo valor
            //numeros[3] = 18;
            //numeros[0] = 5;
            #endregion

            #region CARGAR UN ARRAY-RECORRER CON FOR-EJEMPLO 1
            //1-EJEMPLO 1:
            //int[] numeros = new int[5];

            //numeros[0] = 54;
            //numeros[3] = 52;
            //numeros[2] = 10;
            //numeros[4] = 12;
            //numeros[1] = 82;
            ////el orden q lo cargue no importa siempre tiene en cuenta las posiciones

            ////for Para recorrer el array
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            ////Lenght: devuelve la cantidad maxima de posiciones que tiene mi array
            #endregion
            #region CARGAR UN ARRAY-RECORRER CON FOR-EJEMPLO 2
            //EJEMPLO 2:
            //int[] vectoresDeNumeros = new int[5];

            //vectoresDeNumeros[4] = 12;
            //vectoresDeNumeros[2] = 10;

            ////el orden q lo cargue no importa siempre tiene en cuenta las posiciones
            ////for Para recorrer el array
            //for (int i = 0; i < vectoresDeNumeros.Length; i++)
            //{
            //    Console.WriteLine(vectoresDeNumeros[i]);
            //}
            #endregion
            //*****************************************************************
            #region CARGAR UN ARRAY-RECORRER CON FOR-EJEMPLO 3
            ////EJEMPLO 3: OTRA FORMA:
            // int tamanio = 5;
            // int[] vectoresDeNumeros = new int[tamanio];

            // vectoresDeNumeros[4] = 12;
            // vectoresDeNumeros[2] = 10;

            // for (int i = 0; i < tamanio; i++)
            // {
            //     Console.WriteLine(vectoresDeNumeros[i]);
            // }
            #endregion
            //****************************************************************
            #region HACER UN ARRAY QUE PIDAR INGRESAR NUMEROS Y GUARDARLO EN FORMA CONSECUTIVA-EJEMPLO 4
            ////EJEMPLO 4: 

            //int[] vectorDeNumeros = new int[5];

            //vectorDeNumeros[4] = 12;
            //vectorDeNumeros[2] = 10;

            ////CARGA SECUENCIAL: Hubo una secuencia ordenada y le pido un dato al usuario
            //for (int i = 0; i < vectorDeNumeros.Length; i++)
            //{
            //    Console.WriteLine($"Ingrese el numero {i + 1} de {vectorDeNumeros.Length}");//linea para decirle al usuario q ingrese el numero

            //    int numeroIngresado = int.Parse(Console.ReadLine());//lee (parseo)
            //    vectorDeNumeros[i] = numeroIngresado; //(Asigna) Para guardar el numero ingresado en cada posicion de i

            //    //string lectura = Console.ReadLine();
            //    //int numeroIngresado = int.Parse(lectura); //lee
            //    //vectorDeNumeros[i] = numeroIngresado; //asgina
            //}
            ////CARGA ALEATORIA: PODEMOS HACERLO DE MANERA ALEATORIA:
            ////La asinacion es destructiva -> si el usuario elige una posicion q tenia un valor ese numero se va a pisar
            ////-Tenemos q pedir el numero de posicion en q lo queremos guardar
            ////-el numero q quiere guardar en esa posicion
            //***************************
            #endregion

            #region USANDO FUNCIONES CON ARRAY Ejemplo 5
            //int[] vectorDeNumeros = new int[5];
            //CargarVector(vectorDeNumeros);
            //Console.WriteLine("*************MOSTRAR*************");
            //MostrarVector(vectorDeNumeros);

            //Console.WriteLine("*************MOSTRAR SOLO PARES*************");
            //MostrarPares(vectorDeNumeros);

            //Console.WriteLine("*************SUMANDO POSITIVOS*************");
            //Console.WriteLine($"El valor de la suma de positivos: {SumarPositivos(vectorDeNumeros)}");
            #endregion

            #region USANDO FUNCION ORDENAR VECTOR-VUELTAS DE i y j.Ejemplo 6 
            //int[] vectorDeNumeros = { 25, 12, 85, -12, 6 }; // doy valor de entrada

            //int auxiliar;
            //MostrarVector(vectorDeNumeros);

            //for (int i = 0; i < vectorDeNumeros.Length; i++)
            //{
            //    Console.WriteLine($"Vuelta en {i}");

            //    for (int j = 0; j < vectorDeNumeros.Length; j++)
            //    {
            //        Console.WriteLine($"Vuelta en {j}");

            //        //Comparacion de posiciones
            //        if (vectorDeNumeros[i] < vectorDeNumeros[j]) //poder mover los numeros
            //        {
            //            //Comparar q posicion es mayor q la q sigue
            //            Console.WriteLine(vectorDeNumeros[i]);
            //            Console.WriteLine(vectorDeNumeros[j]);
            //        }
            //    }
            //}
            #endregion

            #region USANDO FUNCION ORDENAR VECTOR-CONTADOR-EJEMPLO 7
            ////Ejemplo 6:
            //int[] vectorDeNumeros = { 25,12,85,-12,6}; // doy valor de entrada

            //int auxiliar ;
            //int contador = 0;
            //Console.WriteLine("Mostrar antes de ordenar*******");
            //MostrarVector(vectorDeNumeros);

            //for (int i = 0; i < vectorDeNumeros.Length; i++)
            //{
            //    for (int j = 0; j < vectorDeNumeros.Length; j++)
            //    {
            //        //Comparacion de posiciones
            //        if (vectorDeNumeros[i] < vectorDeNumeros[j]) //-> si quiero ordenar al reves: (vectorDeNumeros[i] > vectorDeNumeros[j])
            //        {//poder mover los numeros
            //            //Comparar q posicion es mayor q la q sigue

            //            //necesito una variable interna auxiliar
            //            auxiliar = vectorDeNumeros[i];
            //             //guardo lo de i en una variable auxiliar
            //            vectorDeNumeros[i] = vectorDeNumeros[j];
            //            // lo piso
            //            vectorDeNumeros[j] = auxiliar;
            //            //el valor q tenia en j lo recupero con el auxiliar

            //        }
            //        contador++;
            //    }
            //}
            //Console.WriteLine("Mostrar despues de ordenar*******");
            //MostrarVector(vectorDeNumeros);
            //Console.WriteLine($"Cantidad de vueltas {contador}");
            ////por cada vuelta que dio recorrio la 5 posiciones del vector
            #endregion
            #region USANDO FUNCION ORDENAR VECTOR EJEMPLO 8(CAMBIANDO VALOR DE J -> j= i+1 EN FOR DE J)
            ////Ejemplo 8:)
            //int[] vectorDeNumeros = { 25, 12, 85, -12, 6 }; // doy valor de entrada

            //int auxiliar;
            //Console.WriteLine("Mostrar antes de ordenar*******");
            //MostrarVector(vectorDeNumeros);

            //for (int i = 0; i < vectorDeNumeros.Length; i++)
            //{
            //    for (int j = i + 1; j < vectorDeNumeros.Length; j++)
            //    {
            //        //Comparacion de posiciones
            //        if (vectorDeNumeros[i] < vectorDeNumeros[j]) //-> si quiero ordenar al reves: (vectorDeNumeros[i] > vectorDeNumeros[j])
            //        {//poder mover los numeros
            //         //Comparar q posicion es mayor q la q sigue

            //            //necesito una variable interna auxiliar
            //            auxiliar = vectorDeNumeros[i];
            //            //guardo lo de i en una variable auxiliar
            //            vectorDeNumeros[i] = vectorDeNumeros[j];
            //            // lo piso
            //            vectorDeNumeros[j] = auxiliar;
            //            //el valor q tenia en j lo recupero con el auxiliar
            //        }
            //    }
            //}
            //Console.WriteLine("Mostrar despues de ordenar*******");
            //MostrarVector(vectorDeNumeros);
            #endregion
            
            //USANDO FUNCION ORDENAR VECTOR-MAYOR A MENOR/MENOR A MAYOR
            //EJEMPLO 9:
            int[] vectorDeNumeros = { 25, 12, 85, -12, 6 }; // doy valor de entrada

            int auxiliar;
            Console.WriteLine("Mostrar antes de ordenar*******");
            MostrarVector(vectorDeNumeros);

            OrdenarVector1(vectorDeNumeros,true);//MUESTRA DE MENOR A MAYOR
            OrdenarVector1(vectorDeNumeros, false);//MUESTRA DE MAYOR A MENOR

            Console.WriteLine("Mostrar despues de ordenar*******");
            MostrarVector(vectorDeNumeros);
        }

        //FUNCION PARA CARGAR VECTORES:
        public static void CargarVector(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1} de {vector.Length}");//linea para decirle al usuario q ingrese el numero

                int numeroIngresado = int.Parse(Console.ReadLine());//lee (parseo)
                vector[i] = numeroIngresado; //(Asigna) Para guardar el numero ingresado en cada posicion de i

            }
        }

        //FUNCION PARA MOSTRAR VECTOR:
        public static void MostrarVector(int[] vector) 
        {
            foreach (int elementos in vector)
            {
                Console.WriteLine(elementos);//en cada vuelta imprime el elemento
            }

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    Console.WriteLine(vector[i]);
            //}
        }

        //FUNCION PARA MOSTRAR NUMEROS PARES:
        public static void MostrarPares(int[] vector) 
        {
            foreach (int elemento in vector)
            {
                if (elemento % 2 == 0)// && elemento != 0
                {
                    Console.WriteLine(elemento);
                }
            }
        }

        //FUNCION PARA SUMAR POSITIVOS:
        public static int SumarPositivos(int[] vector) 
        {
            int suma = 0;
            foreach (int elemento in vector)
            {
                if (elemento > 0)
                {
                    suma += elemento;
                }
            }
            return suma;
        }
        //FUNCION PARA ORDENAR VECTOR
        public static void OrdenarVector(int[] vector) 
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    //Comparacion de posiciones
                    if (vector[i] < vector[j]) //-> si quiero ordenar al reves: (vectorDeNumeros[i] > vectorDeNumeros[j])
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                        
                    }
                }
            }
        }
        //FUNCION PARA ORDENAR DE MENOR-MAYOR/MAYOR-MENOR
        public static void OrdenarVector1(int[] vector, bool ascendente)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (ascendente)//si ascendente es verdadero
                    {
                        if (vector[i] > vector[j]) //SI ASCENDENTE ESTA EN TRUE : ME LO MUESTA DE MENOR A MAYOR
                        {
                            auxiliar = vector[i];
                            vector[i] = vector[j];
                            vector[j] = auxiliar;
                        }
                    }
                    else 
                    {
                        if (vector[i] < vector[j]) //SI DESCENDENTE ESTA EN FALSE : ME LO MUESTA DE MAYOR A MENOR
                        {
                            auxiliar = vector[i];
                            vector[i] = vector[j];
                            vector[j] = auxiliar;
                        }
                    }  
                }
            }
        }
    }
}
//namespace Clase10_10
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //VECTORES NUMERICOS:
//            //Para guardar numeros: creabamos variables de ese tipo y guardabamos un dato.
//            int unNumero = 8;//variable de tipo entero a la cual se le asigna un unico valor 
//            int otroNumero = 10;

//            //Si queremos agrupar toda la cantidad de datos dentro de una misma variable esa variable es un vector.
          
//        }
//    }
//}
