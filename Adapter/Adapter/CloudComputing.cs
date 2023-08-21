using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CloudComputing
    {
        IAdapter adapter;

        public CloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada cloud computing contas a pagar");
            Thread.Sleep(3000);

            Console.WriteLine(new string('-', 40));

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando camada cloud computing contas a receber");
            Thread.Sleep(3000); 

            Console.WriteLine("\n Finalizado com sucesso!");


        }
    }
}
