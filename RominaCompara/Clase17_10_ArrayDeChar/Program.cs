using BibliotecaDeVectores;

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
            
            #region MOSTRAR CON FOR O FOREACH ***************************************

            //string lectura;
            //Console.Write("Ingrese una palabra: ");
            //lectura = Console.ReadLine();

            //char[] letras = lectura.ToCharArray();
            //Console.WriteLine($"Contenido de la var lectura: {lectura}");

            //Console.WriteLine("Contenido del array");
            ////FOR PARA MOSTRAR
            //for (int i = 0; i < letras.Length; i++)
            //{
            //    Console.Write(letras[i]);//write:en una sola linea

            //}
            ////FOREACH PARA MOSTRAR
            //foreach (char item in letras) // para recorrer
            //{
            //    Console.WriteLine(item);//writeline: una letra abajo de la otra
            //}
            #endregion
           
            #region  MOSTRAR EN REVERSA:******************************************************

            //for (int i = letras.Length -1; i >=0; i--)
            //{
            //    Console.Write(letras[i]);//Write:en una sola linea
            //}
            ////el contenido del array no muto. No se modifica la posicion original del array
            //for (int i = 0; i < letras.Length; i++)
            //{
            //    Console.WriteLine(letras[i]);
            //}
            #endregion
            
            #region FOR PARA CAMBIAR POSICION POR SIGNO ´$´:**********************************

            //for (int i = 0; i < letras.Length; i++)
            //{
            //    if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i'|| letras[i] == 'o' || letras[i] == 'u')
            //    {
            //        letras[i] = '$';
            //    }
            //}
            //foreach (char c in letras) //para mostrar
            //{
            //    Console.Write(c);
            //}
            #endregion
            
            #region CLONAR ARRAY-COPIA DE UNA ARRAY:**********************************

            //Los array tienen asignacion por referencia
            //char[] letras2 = letras;->//puedo asignar un array dentro de otro array pero los dos van a estar apuntando al mismo lugar
            //va a ser la misma direccion de memoria para ambas variables (no son independientes)
            //si quiero tener un segundo array distindo -> una copia exacta q pueda manipular sin q afecte el primero-me genero uno nuevo
            // y lo voy recorriendo posicion a posicion
            char[] letras2 = new char[letras.Length];// genero uno nuevo
            // el contenido de cada posicion se pasa por valor
            for (int i = 0; i < letras.Length; i++)
            {
                letras2[i] = letras[i]; 
            //mi nuevo array en la posicion de i va a tomar el mismo valor
            }
            #endregion

            #region USANDO FUNCIONES CARGAR ARRAY*****************************

            //char[] letras;
            //CargarArray(letras);

            //*****************************************
            //char[] letras = new char[5];

            //CargarArray1(letras);

            //Console.WriteLine("Contenido del array");

            //foreach (char c in letras)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine();
            //******************************************
            ////no estoy limitado por la cantidad de letras
            //char[] letras = CargarArray2();
            #endregion
            
            #region CAMBIAR VALOR DE UNA POSICION MINUS A MAYUS O VICEVERSA

            //Si quiero q letras en la posicion 8 tenga mayuscula

            //char[] letras = CargarArray2();

            //char.ToLower('T'); //cambia a minuscula

            //letras[8] = char.ToUpper(letras[8]);// cambia a mayuscula

            //Console.WriteLine("Contenido del array");
            //foreach (char c in letras)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region USO DE CONTADOR DE CARACTERES>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //char[] letras = CargarArray2();

            //int cantA = 0;//cant de a se resetea cada vez q lo este usando

            //foreach (char c in letras)
            //{
            //    Console.WriteLine(c);
            //    if (char.ToLower(c) == 'a') 
            //    { 
            //        cantA++;
            //    }

            //}
            //Console.WriteLine($"Cantidad de letras a: {cantA}");

            //*******************************************************************
            //CONTADOR CON BUCLE Y CONDICIONAL°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°
            //Al array si o si tengo q darle un valor en el momento q lo declaro.
            //Estoy obligado a definir una posicion inicial en los array

            //while (true)
            //{ 
            //    int cantA = 0;//cant de a se resetea cada vez q lo este usando
            //    char[] letras = CargarArray2(); // ya le defini el tamaño de mi array/ no se puede modificar
            //    foreach (char c in letras)
            //    {
            //        Console.WriteLine(c);

            //        if (char.ToLower(c) == 'a')
            //        {
            //            cantA++;
            //        }
            //    }
            //    Console.WriteLine($"Cantidad de letras a: {cantA}");
            //}
            //*******************************************************************

            //int acumulador = 10;
            //while (true)
            //{
            //    int cantA = 0;//cant de a se resetea cada vez q lo este usando
            //    char[] letras = Vector.CargarArray2(); // ya le defini el tamaño de mi array/ no se puede modificar
            //    for (int i=0;i<letras.Length;i++)
            //    {
            //        Console.WriteLine(letras[i]);

            //        if (char.ToLower(letras[i]) == 'a')
            //        {
            //            cantA++;
            //            letras[i] = '%';
            //            acumulador += letras[i];
            //        }
            //    }
            //    Console.WriteLine($"Cantidad de letras a: {cantA}");
            //}
            //***********************************************************************

            //int acumulador = 10;
            //while (true)
            //{
            //    int cantA = 0;//cant de a se resetea cada vez q lo este usando
            //    char[] letras = Vector.CargarArray2(); // ya le defini el tamaño de mi array/ no se puede modificar

            //    Console.WriteLine($"Cantidad de letras a: {cantA}");
            //}
            #endregion
            //*************************************************************************

            //USANDO FUNCION PARA CONTAR CUALQUIER COSA**********************************************************
            //string seguir = "si";

            //while (true)
            //{
            //    int cantA = 0;
            //    int cantE = 0;
            //    int cantI = 0;
            //    int cantO = 0;
            //    int cantU = 0;

            //    char[] letras = Vector.CargarArray2(); //carga el array

            //    cantA = Vector.ContarLetra1(letras, 'a');// precisa recibir el array(letras) y el caracter q estoy buscando('a')
            //    cantE = Vector.ContarLetra1(letras, 'e'); ;
            //    cantI = Vector.ContarLetra1(letras, 'i'); ;
            //    cantO = Vector.ContarLetra1(letras, 'o'); ;
            //    cantU = Vector.ContarLetra1(letras, 'u'); ;

            //    Console.WriteLine($"Cantidad de letras a: {cantA}");
            //    Console.WriteLine($"Cantidad de letras e: {cantE}");
            //    Console.WriteLine($"Cantidad de letras i: {cantI}");
            //    Console.WriteLine($"Cantidad de letras o: {cantO}");
            //    Console.WriteLine($"Cantidad de letras u: {cantU}");


            //}
            //***********************************************************************
            //contar caracteres especiales
            //while (true)
            //{
            //    int cant1 = 0;

            //    char[] letras = Vector.CargarArray2(); //carga el array

            //    cant1 = Vector.ContarLetra1(letras, '1');// precisa recibir el array(letras) y el caracter q estoy buscando('a')

            //    Console.WriteLine($"Cantidad de 1: {cant1}");
            //}
            //******************************************************************
          
            while (true)
            {
                int cant1 = 0;

                char[] letras = Vector.CargarArray2(); //carga el array

                cant1 = Vector.ContarLetra1(letras, '#');// precisa recibir el array(letras) y el caracter q estoy buscando('a')

                Console.WriteLine($"Cantidad de #: {cant1}");
            }
        }
        //FUNCIONES PARA CARGAR ARRAY:
        public static void CargarArray(char[] vector)
        {
            string lectura;
            Console.Write("Ingrese una palabra: ");

            lectura = Console.ReadLine();
            vector = lectura.ToCharArray();
        }
        public static void CargarArray1(char[] vector)
        {
            string lectura;
            Console.Write("Ingrese una palabra de 5 letras: ");
            lectura = Console.ReadLine();

            while (lectura.Length != 5) 
            {
                Console.Write(">>>>La palabra debe ser de 5 letras<<<");
                Console.Write("Ingrese una palabra de 5 letras: ");
                lectura = Console.ReadLine();

            }
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = lectura[i];
            }
        }
        //public static char[] CargarArray2()// no estoy limitado por la cantidad de letras
        //{
        //    string lectura;
        //    Console.Write("Ingrese una palabra: ");
        //    lectura = Console.ReadLine();//ReadLine te devuelve un string

        //    return lectura.ToCharArray();
        //}
        //

    }
}
