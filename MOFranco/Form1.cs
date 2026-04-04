using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MOFranco
{

    enum EstadoAquecimento
    {
        Parado,
        Aquecendo,
        Pausado
    }


    public partial class FrmPrincipal : Form
    {

        // Variáveis
        private int tempoRestante = 0;
        private int potenciaAtual = 10;
        private bool emExecucao = false;
        private bool pausado = false;
        private int tempoInicial = 0;
        private StringBuilder progresso = new StringBuilder();
        private EstadoAquecimento estadoAtual = EstadoAquecimento.Parado;



        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                // controla estado
                if (estadoAtual == EstadoAquecimento.Pausado)
                {
                    RetomarAquecimento();
                    estadoAtual = EstadoAquecimento.Aquecendo;
                    return; // PARA TUDO AQUI
                }


                // Se já está rodando → soma +30
                if (emExecucao && !pausado)
                {
                    int novoTempo = tempoRestante + 30;

                    ValidarTempo(novoTempo);

                    tempoRestante = novoTempo;
                    tempoInicial += 30;

                    Invoke(new Action(() =>
                    {
                        progressBar1.Maximum = tempoInicial;
                    }));

                    return;
                }



                if (estadoAtual == EstadoAquecimento.Parado)
                {
                    IniciarAquecimento();
                    estadoAtual = EstadoAquecimento.Aquecendo;
                }


                // Início rápido
                if (string.IsNullOrWhiteSpace(txtTempo.Text) &&
                    string.IsNullOrWhiteSpace(txtPotencia.Text))
                {
                    tempoRestante = 30;
                    potenciaAtual = 10;

                    tempoInicial = tempoRestante;

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = tempoInicial;
                    progressBar1.Value = 0;

                    txtTempo.Text = tempoInicial.ToString();
                    txtPotencia.Text = potenciaAtual.ToString();

                }
                else
                {
                    if (!int.TryParse(txtTempo.Text, out tempoRestante))
                        throw new Exception("Tempo inválido");

                    potenciaAtual = string.IsNullOrEmpty(txtPotencia.Text)
                    ? 10
                    : int.Parse(txtPotencia.Text);
                    txtPotencia.Text = potenciaAtual.ToString();


                    ValidarTempo(tempoRestante);
                    ValidarPotencia(potenciaAtual);

                }


                lblInfo.Text = $"Status: {lblStatus.Text} | Tempo: {FormatarTempo(tempoRestante)} | Potência: {potenciaAtual}";

                tempoInicial = tempoRestante;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = tempoInicial;
                progressBar1.Value = 0;

                progresso.Clear();

                emExecucao = true;
                pausado = false;

                lblStatus.Text = "Aquecendo...";

                await AquecerAsync();

                if (estadoAtual == EstadoAquecimento.Parado)
                {
                    LimparTela();
                }
                else
                {
                    lblStatus.Text = "Finalizado!";
                    lblInfo.Text = $"Status: {lblStatus.Text} | Tempo: {FormatarTempo(tempoRestante)} | Potência: {potenciaAtual}";
                    emExecucao = false;
                    estadoAtual = EstadoAquecimento.Parado;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async Task AquecerAsync()
        {

            // while (tempoRestante > 0)
            while (tempoRestante > 0 && emExecucao)
            {
                if (pausado)
                {
                    await Task.Delay(200);
                    continue;
                }

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(100);

                    Invoke(new Action(() =>
                    {
                        int progressoAtual = tempoInicial - tempoRestante;
                        progressBar1.Value = Math.Min(progressoAtual, progressBar1.Maximum);
                    }));
                }

                tempoRestante--;

                // adiciona "." conforme potência (por segundo)
                if (progresso.Length > 0)
                {
                    progresso.Append(" ");
                }

                if ((tempoInicial - tempoRestante) % 20 == 0)
                {
                    progresso.Append(Environment.NewLine);
                }

                progresso.Append(new string('.', potenciaAtual));


                Invoke(new Action(() =>
                {
                    lblProgresso.Text = progresso.ToString();
                    lblTempoFormatado.Text = FormatarTempo(tempoRestante);

                    int progressoAtual = tempoInicial - tempoRestante;
                    // progressBar1.Value = Math.Min(progressoAtual, progressBar1.Maximum);
                    progressBar1.Value = Math.Max(progressBar1.Minimum,
                        Math.Min(progressoAtual, progressBar1.Maximum));

                    lblInfo.Text = $"Status: {lblStatus.Text} | Tempo: {FormatarTempo(tempoRestante)} | Potência: {potenciaAtual}";
                    txtTempo.Text = tempoRestante.ToString();
                }));
            }

            if (tempoRestante == 0)
            {
                Invoke(new Action(() =>
                {
                    lblProgresso.Text = progresso.ToString() + " Aquecimento concluído";
                }));
            }

        }



        // Validação de tempo
        private void ValidarTempo(int tempo)
        {
            if (tempo < 1 || tempo > 120)
                throw new Exception("O tempo deve estar entre 1 e 120 segundos.");
        }

        // Validação de potência
        private void ValidarPotencia(int potencia)
        {
            if (potencia < 1 || potencia > 10)
                throw new Exception("A potência deve estar entre 1 e 10.");
        }

        // Regra da prova (conversão de tempo)
        private string FormatarTempo(int tempo)
        {
            if (tempo >= 60)
            {
                int minutos = tempo / 60;
                int segundos = tempo % 60;

                return $"{minutos}:{segundos:D2}";
            }

            return $"{tempo}s";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // a) Se está aquecendo → PAUSA
            if (estadoAtual == EstadoAquecimento.Aquecendo)
            {
                PausarAquecimento();
                estadoAtual = EstadoAquecimento.Pausado;
            }
            // b) Se está pausado → CANCELA
            else if (estadoAtual == EstadoAquecimento.Pausado)
            {
                CancelarAquecimento();
                LimparTela();
                estadoAtual = EstadoAquecimento.Parado;
            }
            // c) Se nem iniciou → só limpa
            else if (estadoAtual == EstadoAquecimento.Parado)
            {
                LimparTela();
            }
        }


        private void PausarAquecimento()
        {
            if (!emExecucao) return;

            pausado = true;
            lblStatus.Text = "Pausado";

            lblInfo.Text = $"Status: {lblStatus.Text} | Tempo: {FormatarTempo(tempoRestante)} | Potência: {potenciaAtual}";
        }

        private void RetomarAquecimento()
        {
            if (tempoRestante <= 0) return;

            pausado = false;

            lblStatus.Text = "Aquecendo...";
            lblTempoFormatado.Text = FormatarTempo(tempoRestante);

            lblInfo.Text = $"Status: {lblStatus.Text} | Tempo: {FormatarTempo(tempoRestante)} | Potência: {potenciaAtual}";
        }

        private void CancelarAquecimento()
        {
            pausado = false;
            emExecucao = false;
            tempoRestante = 0;
            tempoInicial = 0;

            lblStatus.Text = "Cancelado";

            lblInfo.Text = $"Status: {lblStatus.Text}";
        }

        private void LimparTela()
        {
            txtTempo.Text = "";
            txtPotencia.Text = "";

            lblTempoFormatado.Text = "";
            lblProgresso.Text = "";
            lblStatus.Text = "";
            lblInfo.Text = "";

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            progresso.Clear();
        }

        private void IniciarAquecimento()
        {
            progresso.Clear();
            pausado = false;

            lblStatus.Text = "Aquecendo...";
        }

        private void lblNomePrograma_Click(object sender, EventArgs e)
        {

        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializa estado da UI ao carregar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            lblStatus.Text = string.Empty;
            lblInfo.Text = string.Empty;
            lblProgresso.Text = string.Empty;
            lblTempoFormatado.Text = string.Empty;
        }

    } // Fechamento da classe FrmPrincipal

}
