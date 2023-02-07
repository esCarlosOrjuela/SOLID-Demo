namespace practice.src.InterfaceSegregationPrinciple.Correct
{
    public interface IAve
    {
        void Comer();
    }

    public interface IAveVoladora
    {
        void Volar();
    }

    public interface IAveNadadora
    {
        void Nadar();
    }

    public class Loro : IAve, IAveVoladora
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

    public class Tucan : IAve, IAveVoladora
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

    public class Pinguino : IAve, IAveVoladora, IAveNadadora
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

    /*
     Así, cada clase implementa las interfaces de la que realmente necesita implementar sus métodos.
     A la hora de añadir nuevas funcionalidades, esto nos ahorrará bastante tiempo, y además,
     cumplimos con el primer principio (Responsabilidad Única).
     */
}

