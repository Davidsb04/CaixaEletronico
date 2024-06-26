
using System.Text.Json;

namespace CaixaEletronico.Helper
{
    public class SaqueRepository : ISaqueRepository
    {
        public string CalcularCedulas(int valorSaque)
        {
            List<int> cedulas = new List<int>
            {
                100,
                50,
                20,
                10,
                5,
                2
            };

            List<int>? menorCaminho = null;

            void CalcularCedulasRec(int valorSaque, List<int> cedulas, List<int> caminho, int index) 
            {
                if (valorSaque == 0)
                {
                    if(menorCaminho == null || caminho.Count < menorCaminho.Count)
                    {
                        menorCaminho = new List<int>(caminho);
                    }
                    return;
                }

                if (valorSaque < 0 || index >= cedulas.Count)
                {
                    return;
                }

                caminho.Add(cedulas[index]);
                CalcularCedulasRec(valorSaque - cedulas[index], cedulas, caminho, index); 

                caminho.RemoveAt(caminho.Count - 1);
                CalcularCedulasRec(valorSaque, cedulas,caminho, index + 1);
            }

            var caminho = new List<int>();
            CalcularCedulasRec(valorSaque, cedulas, caminho, 0);

            var resultado = new
            {
                Cedulas = menorCaminho ?? new List<int>()
            };

            var json = JsonSerializer.Serialize(resultado);
            return json;
        }
    }
}
