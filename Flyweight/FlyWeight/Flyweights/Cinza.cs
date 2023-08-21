using FlyWeight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Flyweights
{
    public class Cinza : EspacoNave
    {
        public Cinza()
        {
            this.condicao = "voando em linha reta - ";
            this.acao = "Disparando Lasers ";
        }
        public override void Exibir(string cor, string tamanho)
        {
            this.cor = cor;
            this.tamanho = tamanho;
            Console.WriteLine($"Nave {this.tamanho} e {this.cor}  {this.condicao} {this.acao} ");
        }
    }
    
}
