namespace ContasBasicasTestes
{
    public class Calculadora
    {
        public static int Somar(int n1, int n2)
        { 
            return n1 + n2; 
        }
        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public static double Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return (double)n1 / n2;
        }

    }
}
