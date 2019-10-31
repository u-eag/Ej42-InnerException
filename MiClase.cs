using System;


namespace Ej_42
{
    public class MiClaseEjemplo
    {
        
        //primer constructor que se ejecuta 
        public MiClaseEjemplo()  
        {
            try
            {
                new MiClaseEjemplo(1);    //crea otro objeto al cual le pasa un entero
            }
            catch (Exception excepcion_2)
            {
                //esta linea lanza una nueva excepcion donde adjunto la excepcion para que quede guardada en la 
                // propiedad InnerException del proximo catch.
                throw new MiExcepcionPropia("Fallo en MiClaseEjemplo", excepcion_2); 
            }
        }


        //metodo estatico donde se va a producir el error. 
        public static void MetodoStatic()
        {
            throw new DivideByZeroException();
        }

        //segundo constructor que se ejecuta.
        public MiClaseEjemplo(int num)
        {
            try
            {
                MiClaseEjemplo.MetodoStatic();
            }
            catch (Exception excepcion_1)
            {   
                //esta linea lanza una nueva excepcion donde adjunto la excepcion para que quede guardada en la 
                // propiedad InnerException del proximo catch.
                throw new MiExcepcionPropia("fallo en MiClaseEjemplo con parametro entero", excepcion_1) ;
            }
        }


    }

}
