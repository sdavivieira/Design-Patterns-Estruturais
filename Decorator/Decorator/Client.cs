using Decorator.Decorators;
using Decorator.Interfaces;
using Decorator.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Client
    {
        public void ConsumirServicos()
        {
            IPet banhotosa = new BanhoTosa("banho e tosa", 45.00);

            IPet acessorioDecorator = new AcessorioDecorator(banhotosa);
            IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecorator);

            Console.WriteLine("Resumo dos serviços Pet Shop");
            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine("Valor total: " + luxoSpaDecorator.GetValorServico());

        }
    }
}
