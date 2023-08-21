using Bridge.Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Client
    {
        public IMaterial Material { get; set; } 

        public void ConsultarCanetasPinceisNoEstoque()
        {
            Console.WriteLine((this.Material.ConsultarNoEstoque()));
        }
    }
}
