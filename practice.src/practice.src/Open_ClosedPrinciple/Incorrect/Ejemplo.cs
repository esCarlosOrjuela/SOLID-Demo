using System;
using System.Diagnostics;

namespace practice.src.Open_ClosedPrinciple.Incorrect
{
    public class Coche
    {
        public string Marca { get; set; } = string.Empty;

        public Coche() { }
    }

    public class Main
    {
        public Main()
        {
            var coches = new List<Coche>()
            {
                new Coche{ Marca = "Audi"},
                new Coche{ Marca = "Renault"},
                new Coche{ Marca = "Chevrolet"}
            };

            this.ImprimirPrecioMedioCoche(coches);
        }

        public void ImprimirPrecioMedioCoche(List<Coche> arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                switch (coche.Marca)
                {
                    case "Audi":
                        Debug.WriteLine("15'000.000");
                        break;
                    case "Renault":
                        Debug.WriteLine("5'000.000");
                        break;
                    case "Chevrolet":
                        Debug.WriteLine("9'000.000");
                        break;
                }
            }
        }
    }

    /*
     Esto no cumpliría el principio abierto/cerrado, ya que si decidimos añadir un nuevo coche de otra marca:

     * new Coche("Mercedes")

     También tendríamos que modificar el método que hemos creado anteriormente:

     case "Mercedes":
         Debug.WriteLine("20'000.000");
        break;

    Para que cumpla con este principio podríamos hacer lo siguiente:

    Cada coche extiende la clase abstracta Coche e implementa el método abstracto precioMedioCoche().

     */
}

