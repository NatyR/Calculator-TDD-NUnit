using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CalculatorTDD
{
    public class CalculatorTDDProj
    {
        public static int Add(string num)
        {
            var parts = num.Split(',');
            var resultado = 0;
            var negativo = new List<int>();
            int numero;


            foreach (var part in parts)
            {
                int.TryParse(part, out numero);

                if (numero < 0)
                {
                    negativo.Add(numero);
                }
                else if (numero <= 1000)
                {
                    resultado += numero;
                }
            }

            if (negativo.Count > 0)
            {
                var listaNegativa = string.Join(",", negativo);
                var mensagemExcecao = $"Números negativos não são permitidos para o cálculo: {listaNegativa}.";
                throw new Exception(mensagemExcecao);
            }

            return resultado;
        }
    }
}
