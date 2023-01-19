using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoMoedas.Entidades
{
    public class Moedas
    {
        public decimal real { get; set; }

        public decimal dolar = 5.10m;

        public decimal euro = 5.50m;

        public decimal pesoArgentinos = 0.028m;

        public decimal bathTailandes = 0.15m;

        public decimal conversao { get; set; }
    }
}
