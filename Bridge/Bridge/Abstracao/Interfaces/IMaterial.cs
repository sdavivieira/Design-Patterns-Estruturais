﻿using Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstracao.Interfaces
{
    public interface IMaterial
    {
        public ICor CorImplementacao { get; set; }

        string ConsultarNoEstoque();
    }
}
