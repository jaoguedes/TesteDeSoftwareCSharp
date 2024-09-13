using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBasicasTestes
{
    public class Voto
    {
        public static string PodeVotar(int idade)
        {
            if (idade < 16)
            {
                return "Não pode votar";
            }
            else if ((idade >= 18 && idade <= 70))
            {
                return "Voto obrigatório";
            }
            else if ((idade >= 16 && idade < 18) || idade > 70)
            {
                return "Voto facultativo";
            }
            else
            {
                return "Idade inválida";
            }
        }
    }
}
