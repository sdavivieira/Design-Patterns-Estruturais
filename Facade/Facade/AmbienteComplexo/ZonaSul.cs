using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            Console.WriteLine("SELECT * FROM (*) - Executando rotina zona sul");
            return new List<object>();
        }
    }
}
