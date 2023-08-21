using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Servico
{
    public class BanhoTosa : IPet
    {
        private string _NomeServico;
        private double _ValorServico;

        public BanhoTosa(string nomeServico, double valorServico)
        {
            _NomeServico = nomeServico;
            _ValorServico = valorServico;
        }

        public string GetNomeServico()
        {
            return _NomeServico;
        }

        public double GetValorServico()
        {
            return _ValorServico;
        }
    }
}
