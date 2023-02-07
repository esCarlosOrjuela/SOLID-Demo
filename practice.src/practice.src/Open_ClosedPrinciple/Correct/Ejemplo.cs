using System.Diagnostics;

namespace practice.src.Open_ClosedPrinciple.Correct
{
    /*
     Cada coche extiende la clase abstracta Coche e implementa el método abstracto precioMedioCoche().

     Así, cada coche tiene su propia implementación del método precioMedioCoche(), por lo que el método
     imprimirPrecioMedioCoche() itera el array de coches y solo llama al método precioMedioCoche().

     Ahora, si añadimos un nuevo coche, precioMedioCoche() no tendrá que ser modificado. Solo tendremos
     que añadir el nuevo coche al array, cumpliendo así el principio abierto/cerrado.

     */

    public abstract class Coche
    {
        public abstract string PrecioMedioCoche();
    }

    public class Audi : Coche
    {
        public override string PrecioMedioCoche()
        {
            return "15'000.000";
        }
    }

    public class Mercedes : Coche
    {
        public override string PrecioMedioCoche()
        {
            return "20'000.000";
        }
    }

    public class Renault : Coche
    {
        public override string PrecioMedioCoche()
        {
            return "5'000.000";
        }
    }

    public class Main
    {
        public Main()
        {
            var coches = new List<Coche>()
            {
                new Audi(),
                new Renault(),
                new Mercedes()
            };

            this.ImprimirPrecioMedioCoche(coches);
        }

        public void ImprimirPrecioMedioCoche(List<Coche> arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                Debug.WriteLine(coche.PrecioMedioCoche());
            }
        }
    }
}

