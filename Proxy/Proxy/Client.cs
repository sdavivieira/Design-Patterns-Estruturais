using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client
    {
        public void TentarConexaoClientVPN()
        {
            VPNProxy proxy= new VPNProxy();
            Console.WriteLine("Digite o Username: ");
            string username = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string password = Console.ReadLine();

            var user = new User(username, password);
            proxy.AcessarVPN(user);
        }
    }
}
