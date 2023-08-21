using Proxy.Interface;
using Proxy.Model;
using Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DataBaseConnection sql = new DataBaseConnection();
            sql.RegistrarAcessoVPN(user);
            Console.WriteLine(new string ('-', 40));
            VPN vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}
