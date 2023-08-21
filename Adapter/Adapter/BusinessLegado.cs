using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            Console.WriteLine("\n Processando regras de negócio contas a pagar. . . ");
            Console.WriteLine(result);
            Thread.Sleep(3000);

            return result;
        }
        public string ExecutarRotinaContasReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);
            Console.WriteLine("\n Processando regras de negócio contas a pagar. . . ");
            Console.WriteLine(result);
            Thread.Sleep(3000);

            return result;
        }

    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
        Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("junho", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("julho", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("agosto", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("setembro", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("outubro", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");


            return dic[mes];

        }
        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("julho", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("agosto", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("setembro", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");
            dic.Add("outubro", "CNPJ: 12334532122\nRazão Social: Lojas Prudente\nValor: 1200.00\n Contato: (22) 1232-2333");


            return dic[mes];

        }

    }
}
