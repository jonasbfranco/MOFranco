namespace MOFranco
{
    public class ProgramaService
    {
        private readonly List<ProgramaAquecimento> programasCustomizados;

        public ProgramaService(List<ProgramaAquecimento> programasCustomizados)
        {
            this.programasCustomizados = programasCustomizados;
        }

        public void ValidarPrograma(ProgramaAquecimento programa)
        {
            if (programa == null)
                throw new Exception("Programa inválido.");

            if (string.IsNullOrWhiteSpace(programa.Nome))
                throw new Exception("Nome obrigatório.");

            if (string.IsNullOrWhiteSpace(programa.Alimento))
                throw new Exception("Alimento obrigatório.");

            if (programa.Tempo < 1 || programa.Tempo > 900)
                throw new Exception("Tempo inválido.");

            if (programa.Potencia < 1 || programa.Potencia > 10)
                throw new Exception("Potência inválida.");

            ValidarCaractere(programa.StringAquecimento, programa);
        }

        public void ValidarCaractere(string caractere, ProgramaAquecimento atual = null)
        {
            if (string.IsNullOrWhiteSpace(caractere))
                throw new Exception("Caractere obrigatório.");

            if (caractere.Length != 1)
                throw new Exception("Informe apenas um único caractere.");

            var proibidos = new[] { "*", "~", "#", "@", "%", "." };

            if (proibidos.Contains(caractere))
                throw new Exception("Caractere já utilizado por programas padrão.");

            bool existe = programasCustomizados.Any(p =>
                p.StringAquecimento == caractere && p != atual);

            if (existe)
                throw new Exception("Caractere já utilizado em outro programa.");
        }

        public void Adicionar(ProgramaAquecimento programa)
        {
            ValidarPrograma(programa);
            programasCustomizados.Add(programa);
        }

        public void Atualizar(ProgramaAquecimento programa)
        {
            ValidarPrograma(programa);
        }


        public void Remover(ProgramaAquecimento programa)
        {
            if (programa == null)
                throw new Exception("Programa inválido.");

            if (!programasCustomizados.Contains(programa))
                throw new Exception("Programa não encontrado.");

            programasCustomizados.Remove(programa);
        }
    }
}