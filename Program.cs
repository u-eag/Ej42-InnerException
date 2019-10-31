using System;

namespace Ej_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                MiClaseEjemplo miClase = new MiClaseEjemplo();
            }
            catch (Exception ex)
            {
                // Va a mostrar el mensaje lanzado en el metodo anterior
                // Es decir,   "Fallo en MiClaseEjemplo". 
                Console.WriteLine(ex.Message);

                // Para poder acceder a las excepciones que vienen por Inner, hay que llamar a la misma.
                // Aca estariamos mostrando  "fallo en MiClaseEjemplo con parametro entero"
                Console.WriteLine(ex.InnerException.Message);


                // Para mostrar el error original, es decir, el "intento dividir por 0", lo hacemos 1 vez mas
                Console.WriteLine(ex.InnerException.InnerException.Message);

                // La forma correcta seria recorrer las Inner exception. Una forma seria con un while o un doWhile
                Console.Clear();
                Console.WriteLine(ex.Message);

                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }

                /*   
                 Basicamente en la propiedad InnerException se guarda el Objeto Exception que fue arrojado previamente. 
                */

            }
            Console.ReadKey();
        }
    }
}
