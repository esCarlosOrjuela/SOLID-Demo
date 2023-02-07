using System;
namespace practice.src.InterfaceSegregationPrinciple.Incorrect
{
    public interface IAve
    {
        void Volar();
        void Comer();
    }

    public class Loro : IAve
    {
        public void Comer()
        {
            /// ....
        }

        public void Volar()
        {
            /// ....
        }
    }

    public class Tucan : IAve
    {
        public void Comer()
        {
            /// ....
        }

        public void Volar()
        {
            /// ....
        }
    }

    /*
     Pero ahora imaginemos que queremos añadir a los pingüinos. Estos son aves, pero además tienen la habilidad de nadar.
    Podríamos hacer esto:

    A la interface IAve agregar el metodo

    void Nadar();

    luego creamos la clase pinguino

    public class Pinguino : IAve
    {
        public void Comer()
        {
            /// ....
        }

        public void Volar()
        {
            /// ....
        }

        public void Nadar()
        {
            /// ....
        }
     }

    El problema es que el loro no nada, y el pingüino no vuela, por lo que tendríamos que añadir una excepción o aviso
    si se intenta llamar a estos métodos. Además, si quisiéramos añadir otro método a la interfaz IAve, tendríamos que
    recorrer cada una de las clases que la implementa e ir añadiendo la implementación de dicho método en todas ellas.
    Esto viola el principio de segregación de interfaz, ya que estas clases (los clientes) no tienen por qué depender
    de métodos que no usan.

     */
}

