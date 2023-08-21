using Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Client
    {
        public void EfetuarCompra()
        {
            ComponentModel product01 = new ProductLeaf("Caneca", 25.00);        
            ComponentModel product02 = new ProductLeaf("blusa", 20.00);        
            ComponentModel product03 = new ProductLeaf("calça", 80.00);  

            ComponentModel product04 = new ProductLeaf("Maquina", 500.00);

            ComponentModel smallBox = new ProductComposite();

            smallBox.Add(product01,product02,product03);

            ComponentModel BigBox = new ProductComposite();
            BigBox.Add(smallBox, product04);

            var valorTotal = BigBox.Operation();

            Console.WriteLine($"\nValor Total: {valorTotal.ToString("C")}");
            
        }
    }
}
