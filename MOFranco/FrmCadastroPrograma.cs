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
            catch
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
