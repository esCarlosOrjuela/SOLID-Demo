using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practice.src.DependencyInversionPrinciple.Correct
{
    /*
     Para arreglar esto, podemos hacer que el módulo AccesoADatos dependa de una abstracción más genérica:
     */

    interface IConexion
    {
        void GetDatos();
        void SetDatos();
    }

    class AccesoADatos
    {

        private IConexion conexion;

        public AccesoADatos(IConexion conexion)
        {
            this.conexion = conexion;
        }

        void GetDatos()
        {
            conexion.GetDatos();
        }
    }

    /*
     Así, sin importar el tipo de conexión que se le pase al módulo AccesoADatos,
     ni este ni sus instancias tendrán que cambiar, por lo que nos ahorraremos mucho trabajo.
     *
     Ahora, cada servicio que queramos pasar a AccesoADatos deberá implementar la interfaz Conexion:
     */

    class DatabaseService : IConexion
    {
        public void GetDatos()
        {
            //...
        }

        public void SetDatos()
        {
            //...
        }
    }

    class APIService : IConexion
    {
        public void GetDatos()
        {
            //...
        }

        public void SetDatos()
        {
            //...
        }
    }

    /*
     Así, tanto el módulo de alto nivel como el de bajo nivel dependen de abstracciones,
     por lo que cumplimos el principio de inversión de dependencias. Además, esto nos forzará
     a cumplir el principio de Liskov, ya que los tipos derivados de Conexion (DatabaseService y APIService)
     son sustituibles por su abstracción (interfaz Conexion). 
     */
}

