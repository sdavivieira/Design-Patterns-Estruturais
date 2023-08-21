using Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementacao
{
    public class Preto : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            
        //Simulando consulta no banco
        var random = new Random();
        var quantidade = random.Next(100, 500);

            return ($"Existem {quantidade} para {tipoAbstracao} de cor Preto no estoque");
        }
    }
}
