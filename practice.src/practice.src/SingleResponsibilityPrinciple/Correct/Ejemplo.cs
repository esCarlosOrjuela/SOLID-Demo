using System;
namespace practice.src.SingleResponsibilityPrinciple.Correct
{
    /*
     Para evitar esto, debemos separar las responsabilidades de la clase,
     por lo que podemos crear otra clase que se encargue de las operaciones a la BBDD: 
     */

    public class Coche
    {
        public string Marca { get; set; } = string.Empty;
    }

    public class CocheBD
    {
        public CocheBD() { }

        public void GuardarCocheDB(Coche coche) { /*...*/ }
        public void EliminarCocheDB(Coche coche) { /*..*/ }
    }
}

