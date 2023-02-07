namespace practice.src.DependencyInversionPrinciple.Incorrect
{
    class DatabaseService
    {
        public void GetDatos()
        {
            //... 
        }

        class AccesoADatos
        {

            private DatabaseService databaseService;

            public AccesoADatos(DatabaseService databaseService)
            {
                this.databaseService = databaseService;
            }

            void GetDatos()
            {
                databaseService.GetDatos();
                //...
            }
        }
    }

    /*
     Imaginemos que en el futuro queremos cambiar el servicio de BBDD por un servicio que conecta con una API.
     Para un minuto a pensar qué habría que hacer... ¿Ves el problema? Tendríamos que ir modificando todas las
     instancias de la clase AccesoADatos, una por una.

     Esto es debido a que nuestro módulo de alto nivel (AccesoADatos) depende de un módulo de más bajo nivel
     (DatabaseService), violando así el principio de inversión de dependencias. El módulo de alto nivel debería
     depender de abstracciones.
     */
}

