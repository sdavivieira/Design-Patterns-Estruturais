﻿using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.SQL
{
    public class DataBaseConnection
    {
        public void RegistrarAcessoVPN(User user) 
        {
            var query = $"INSERT INTO TB_RegistroVPN (User, Password, DataHora)\n VALUES('{user.Username}', '{user.Password}', {DateTime.Now.ToString("yyyy-MM-dd-H-mm:ss")}\n";
            Console.WriteLine("[!] - Registrando acesso pelo prox .. . \n");
            Console.WriteLine(query);
        }
    }
}
