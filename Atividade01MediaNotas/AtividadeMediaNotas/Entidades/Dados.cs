using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMediaNotas.Entidades
{
    public class Dados
    {
        public int quantidadeAlunos { get; set; }

        public decimal valorProva { get; set; } 

        public decimal[] nota = new decimal[100]; 
        public decimal soma { get; set; }
        public decimal media { get; set; }
    }
}
