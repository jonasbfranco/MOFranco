using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOFranco
{
    public partial class FrmCadastroPrograma : Form
    {

        public ProgramaAquecimento? Programa { get; private set; }

        public List<ProgramaAquecimento> ProgramasExistentes { get; set; }


        public FrmCadastroPrograma(ProgramaAquecimento programa = null)
        {
            InitializeComponent();


            if (programa != null)
            {
                Programa = programa;

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
                    MessageBox.Show("Nome precisa ser preenchido.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(alimento))
                {
                    MessageBox.Show("Alimento precisa ser preenchido.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAlimento.Focus();
                    return;
                }

                
                // VALIDAÇÃO DE NÚMEROS
                if (!int.TryParse(txtTempo.Text, out int tempo))
                {
                    MessageBox.Show("Tempo inválido. Digite apenas números.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTempo.Focus();
                    txtTempo.SelectAll();
                    return;
                }

                if (!int.TryParse(txtPotencia.Text, out int potencia))
                {
                    MessageBox.Show("Potência inválida. Digite apenas números.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPotencia.Focus();
                    txtPotencia.SelectAll();
                    return;
                }

                // VALIDAÇÕES DE TEXTO
                if (string.IsNullOrWhiteSpace(caractere))
                {
                    MessageBox.Show("Caractere precisa ser preenchido.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaractere.Focus();
                    return;
                }


                // VALIDAÇÃO DO CARACTERE
                if (caractere.Length != 1)
                {
                    MessageBox.Show("Informe apenas um único caractere.", "Validação",
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

                // CRIA O PROGRAMA
                Programa = new ProgramaAquecimento
                {
                    Nome = nome,
                    Alimento = alimento,
                    Tempo = tempo,
                    Potencia = potencia,
                    StringAquecimento = caractere,
                    Instrucoes = instrucoes
                };

                DialogResult = DialogResult.OK;
                Close();
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
