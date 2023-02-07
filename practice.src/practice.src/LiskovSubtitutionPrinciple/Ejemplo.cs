using System.Diagnostics;

namespace practice.src.LiskovSubtitutionPrinciple
{
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

    /*
     Como podemos ver, ahora el método ImprimirPrecioMedioCoche() no necesita saber con qué tipo de coche va a realizar su lógica,
     simplemente llama al método PrecioMedioCoche() del tipo Coche, ya que por contrato, una subclase de Coche debe implementar dicho método.
     */

}

