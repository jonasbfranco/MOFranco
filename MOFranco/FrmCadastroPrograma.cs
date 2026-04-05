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

                string nome = txtNome.Text;
                string alimento = txtAlimento.Text;
                int tempo = int.Parse(txtTempo.Text);
                int potencia = int.Parse(txtPotencia.Text);
                string caractere = txtCaractere.Text;
                string instrucoes = txtInstrucoes.Text;

                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(alimento) ||
                    string.IsNullOrWhiteSpace(caractere))
                {
                    throw new Exception("Preencha todos os campos obrigatórios.");
                }

                if (caractere.Length != 1)
                {
                    throw new Exception("Informe apenas um único caractere.");
                }

                // valida caracteres proibidos
                var caracteresPadrao = new[] { "*", "~", "#", "@", "%", "." };

                if (caracteresPadrao.Contains(caractere))
                {
                    MessageBox.Show("Caractere já utilizado por programas padrão.");

                    txtCaractere.Focus();       // volta foco
                    txtCaractere.SelectAll();   // seleciona para corrigir
                    return;                     // NÃO fecha o form
                }


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
                //MessageBox.Show("Preencha os campos corretamente.");
                MessageBox.Show(ex.Message);
                txtCaractere.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
