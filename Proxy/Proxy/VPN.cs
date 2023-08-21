using Proxy.Interface;
using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            Console.WriteLine("[+] ACESSANDO VPN\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.Username} Você está logado na VPN");
        }
    }
}
