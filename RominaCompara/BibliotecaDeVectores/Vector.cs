namespace BibliotecaDeVectores
{
    public static class Vector
    {
        //METODO PARA CARGAR ARRAY
        public static char[] CargarArray2()// no estoy limitado por la cantidad de letras
        {
            string lectura;
            Console.Write("Ingrese una palabra: ");
            lectura = Console.ReadLine();//ReadLine te devuelve un string

            return lectura.ToCharArray();
        }
        //METODO PARA CONTAR LETRAS
        public static int ContarLetra(char[] vector)
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

                if (char.ToLower(vector[i]) == 'a')
                {
                    contador++;
                    
                }
            }
            return contador;
        }
        //METODO PARA CONTAR CUALQUIER COSA: QUE ME PASEN EL VALOR Y CONTARLO
       //sirve para contar cualquier letra q yo le pase(vocales, consonantes,caracteres etc)
        public static int ContarLetra1(char[] vector, char valorBuscado)
        {
            int contador = 0;//contador se recetea dento del metodo
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valorBuscado)
                {
                    contador++;

                }
            }
            return contador;
        }
        public static int ContarLetra2(char[] vector, char valorBuscado)
        {
            int contador = 0;//contador se recetea dento del metodo
            foreach (char c in vector)
            {
                if (c == valorBuscado)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
