﻿using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class LuxoSpaDecorator : PetDecorator
    {
        public LuxoSpaDecorator(IPet pet) : base(pet)
        {
        }

        public override double GetValorServico()
        {
            return base.GetValorServico() + 200.00;
        }
        public override string GetNomeServico()
        {
            return base.GetNomeServico() + "\n[+] Luxo Spa" ;
        }
    }
}
