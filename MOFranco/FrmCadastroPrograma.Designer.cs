namespace MOFranco
{
    partial class FrmCadastroPrograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            lblNome = new Label();
            lblAlimento = new Label();
            txtAlimento = new TextBox();
            lblTempo = new Label();
            txtTempo = new TextBox();
            lblPotência = new Label();
            txtPotencia = new TextBox();
            lblCaractere = new Label();
            txtCaractere = new TextBox();
            lblInstruções = new Label();
            txtInstrucoes = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(165, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(44, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(243, 38);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(56, 15);
            lblAlimento.TabIndex = 3;
            lblAlimento.Text = "Alimento";
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(243, 56);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(165, 23);
            txtAlimento.TabIndex = 2;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(447, 38);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(44, 15);
            lblTempo.TabIndex = 5;
            lblTempo.Text = "Tempo";
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(447, 56);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(165, 23);
            txtTempo.TabIndex = 4;
            // 
            // lblPotência
            // 
            lblPotência.AutoSize = true;
            lblPotência.Location = new Point(44, 102);
            lblPotência.Name = "lblPotência";
            lblPotência.Size = new Size(53, 15);
            lblPotência.TabIndex = 7;
            lblPotência.Text = "Potência";
            // 
            // txtPotencia
            // 
            txtPotencia.Location = new Point(44, 120);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.Size = new Size(165, 23);
            txtPotencia.TabIndex = 6;
            // 
            // lblCaractere
            // 
            lblCaractere.AutoSize = true;
            lblCaractere.Location = new Point(243, 102);
            lblCaractere.Name = "lblCaractere";
            lblCaractere.Size = new Size(57, 15);
            lblCaractere.TabIndex = 9;
            lblCaractere.Text = "Caractere";
            // 
            // txtCaractere
            // 
            txtCaractere.Location = new Point(243, 120);
            txtCaractere.Name = "txtCaractere";
            txtCaractere.Size = new Size(165, 23);
            txtCaractere.TabIndex = 8;
            // 
            // lblInstruções
            // 
            lblInstruções.AutoSize = true;
            lblInstruções.Location = new Point(44, 164);
            lblInstruções.Name = "lblInstruções";
            lblInstruções.Size = new Size(61, 15);
            lblInstruções.TabIndex = 11;
            lblInstruções.Text = "Instruções";
            // 
            // txtInstrucoes
            // 
            txtInstrucoes.Location = new Point(44, 182);
            txtInstrucoes.Multiline = true;
            txtInstrucoes.Name = "txtInstrucoes";
            txtInstrucoes.Size = new Size(568, 79);
            txtInstrucoes.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(431, 303);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(537, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCadastroPrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblInstruções);
            Controls.Add(txtInstrucoes);
            Controls.Add(lblCaractere);
            Controls.Add(txtCaractere);
            Controls.Add(lblPotência);
            Controls.Add(txtPotencia);
            Controls.Add(lblTempo);
            Controls.Add(txtTempo);
            Controls.Add(lblAlimento);
            Controls.Add(txtAlimento);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            MaximizeBox = false;
            Name = "FrmCadastroPrograma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Programas de Aquecimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblAlimento;
        private TextBox txtAlimento;
        private Label lblTempo;
        private TextBox txtTempo;
        private Label lblPotência;
        private TextBox txtPotencia;
        private Label lblCaractere;
        private TextBox txtCaractere;
        private Label lblInstruções;
        private TextBox txtInstrucoes;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}