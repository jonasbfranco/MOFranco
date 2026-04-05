using System;
using System.Collections.Generic;
using System.Text;

namespace MOFranco
{
    public class ProgramaAquecimento
    {
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string StringAquecimento { get; set; }
        public string Instrucoes { get; set; }

        
        public override string ToString()
            {
                return Nome;
            }
    }

}
