using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            Console.WriteLine("SELECT * FROM (*) - Executando rotina zona norte");
            return new List<object>();
        }
    }
}
