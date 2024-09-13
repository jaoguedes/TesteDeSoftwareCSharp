
namespace ContasBasicasTestes
{
    public class EquacaoQuadratica
    {
        public static (double? raiz1, double? raiz2) CalcularRaizes(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return (raiz1, raiz2);
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                return (raiz, raiz);
            }
            else
            {
                return (null, null);
            }
        }
    }
}
