using System;
namespace practice.src.SingleResponsibilityPrinciple.Incorrect
{
    public class Coche
    {
        public string Marca { get; set; } = string.Empty;

        public Coche(string marca)
        {
            this.Marca = marca;
        }

        public void GuardarCocheInBD()
        {
            /// Codigo que guarda el cocke
        }
    }


    /* 
     * PROBLEMA
     * 
    Como podemos observar, la clase Coche permite tanto el acceso a las propiedades de la clase
    como a realizar operaciones sobre la BBDD, por lo que la clase ya tiene más de una responsabilidad.

    Supongamos que debemos realizar cambios en los métodos que realizan las operaciones a la BBDD.
    En este caso, además de estos cambios, probablemente tendríamos que tocar los nombres o tipos
    de las propiedades, métodos, etc, cosa que no parece muy eficiente porque solo estamos modificando
    cosas que tienen que ver con la BBDD, ¿verdad?
     */
}

