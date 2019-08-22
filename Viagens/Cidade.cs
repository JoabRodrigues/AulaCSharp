﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagens
{
    public class Cidade
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public IList<Voo> Partidas { get; set; }
        public IList<Voo> Chegadas { get; set; }
    }
}
