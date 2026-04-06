using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MOFranco
{


    public partial class FrmCadastroPrograma : Form
    {

        private bool modoEdicao = false;

        private const string TITULO_VALIDACAO = "Validação";

        public ProgramaAquecimento? Programa { get; private set; }

        public List<ProgramaAquecimento> ProgramasExistentes { get; set; }


        public FrmCadastroPrograma(ProgramaAquecimento programa = null)
        {
            InitializeComponent();

            if (programa != null)
            {
                Programa = programa;
                modoEdicao = true;

                txtNome.Text = programa.Nome;
                txtAlimento.Text = programa.Alimento;
                txtTempo.Text = programa.Tempo.ToString();
                txtPotencia.Text = programa.Potencia.ToString();
                txtCaractere.Text = programa.StringAquecimento;
                txtInstrucoes.Text = programa.Instrucoes;
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string alimento = txtAlimento.Text.Trim();
                string caractere = txtCaractere.Text.Trim();
                string instrucoes = txtInstrucoes.Text.Trim();

                // VALIDAÇÕES DE TEXTO
                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("Nome precisa ser preenchido.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(alimento))
                {
                    MessageBox.Show("Alimento precisa ser preenchido.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAlimento.Focus();
                    return;
                }

                
                // VALIDAÇÃO DE NÚMEROS
                if (!int.TryParse(txtTempo.Text, out int tempo))
                {
                    MessageBox.Show("Tempo inválido. Digite apenas números.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTempo.Focus();
                    txtTempo.SelectAll();
                    return;
                }
                // VALIDAÇÃO DE REGRAS DE NEGÓCIO
                if (tempo < 1 || tempo > 900)
                {
                    MessageBox.Show("Tempo deve estar entre 1 e 900 segundos.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTempo.Focus();
                    txtTempo.SelectAll();
                    return;
                }


                if (!int.TryParse(txtPotencia.Text, out int potencia))
                {
                    MessageBox.Show("Potência inválida. Digite apenas números.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPotencia.Focus();
                    txtPotencia.SelectAll();
                    return;
                }
                // VALIDAÇÃO DE REGRAS DE NEGÓCIO
                if (potencia < 1 || potencia > 10)
                {
                    MessageBox.Show("Potência deve estar entre 1 e 10.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPotencia.Focus();
                    txtPotencia.SelectAll();
                    return;
                }



                // VALIDAÇÕES DE TEXTO
                if (string.IsNullOrWhiteSpace(caractere))
                {
                    MessageBox.Show("Caractere precisa ser preenchido.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaractere.Focus();
                    return;
                }


                // VALIDAÇÃO DO CARACTERE
                if (caractere.Length != 1)
                {
                    MessageBox.Show("Informe apenas um único caractere.", TITULO_VALIDACAO,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaractere.Focus();
                    txtCaractere.SelectAll();
                    return;
                }


                var caracteresPadrao = new[] { "*", "~", "#", "@", "%", "." };

                if (caracteresPadrao.Contains(caractere))
                {
                    MessageBox.Show(
                        "Este caractere já está sendo usado.\nEscolha outro para continuar.",
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtCaractere.Focus();
                    txtCaractere.SelectAll();
                    return;
                }

                // valida duplicidade entre customizados
                if (ProgramasExistentes != null)
                {
                    bool existe = ProgramasExistentes.Any(p =>
                        p.StringAquecimento == caractere);

                    if (existe)
                    {
                        MessageBox.Show(
                            "Este caractere já está sendo usado por outro programa.",
                            "Validação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        txtCaractere.Focus();
                        txtCaractere.SelectAll();
                        return;
                    }
                }


                // Cria o programa com os dados preenchidos
                if (modoEdicao && Programa != null)
                {
                    // Atualiza o mesmo objeto
                    Programa.Nome = nome;
                    Programa.Alimento = alimento;
                    Programa.Tempo = tempo;
                    Programa.Potencia = potencia;
                    Programa.StringAquecimento = caractere;
                    Programa.Instrucoes = instrucoes;
                }
                else
                {
                    // Cria novo
                    Programa = new ProgramaAquecimento
                    {
                        Nome = nome,
                        Alimento = alimento,
                        Tempo = tempo,
                        Potencia = potencia,
                        StringAquecimento = caractere,
                        Instrucoes = instrucoes
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
