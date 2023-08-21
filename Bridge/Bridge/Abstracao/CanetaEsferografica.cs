using Bridge.Abstracao.Interfaces;
using Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarNoEstoque()
        {
            return this.CorImplementacao.ConsultarQuantidadePorCor("Caneta Esferografica");
        }
    }
}
