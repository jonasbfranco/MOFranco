using System;
using System.Collections.Generic;
using System.Text;

namespace MOFranco
{
    public class ProgramaAquecimento
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string Nome { get; set; } = string.Empty;
        public string Alimento { get; set; } = string.Empty;
        public string StringAquecimento { get; set; } = string.Empty;
        public string Instrucoes { get; set; } = string.Empty;
        public int Tempo { get; set; }
        public int Potencia { get; set; }


        public override string ToString()
            {
                return Nome;
            }
    }

}
