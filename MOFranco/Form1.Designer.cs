namespace MOFranco
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTempo = new TextBox();
            lblTempo = new Label();
            lblPotencia = new Label();
            txtPotencia = new TextBox();
            btnIniciar = new Button();
            progressBar1 = new ProgressBar();
            lblInfo = new Label();
            lblStatus = new Label();
            lblProgresso = new Label();
            lblTempoFormatado = new Label();
            btnCancelar = new Button();
            lblNomePrograma = new Label();
            SuspendLayout();
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(165, 117);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 0;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(81, 125);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(70, 15);
            lblTempo.TabIndex = 1;
            lblTempo.Text = "Tempo(seg)";
            // 
            // lblPotencia
            // 
            lblPotencia.AutoSize = true;
            lblPotencia.Location = new Point(279, 125);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(53, 15);
            lblPotencia.TabIndex = 3;
            lblPotencia.Text = "Potência";
            // 
            // txtPotencia
            // 
            txtPotencia.Location = new Point(346, 117);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.Size = new Size(100, 23);
            txtPotencia.TabIndex = 2;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(460, 117);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(81, 381);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(546, 23);
            progressBar1.TabIndex = 5;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(81, 173);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(28, 15);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Info";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(81, 218);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // lblProgresso
            // 
            lblProgresso.AutoSize = true;
            lblProgresso.Location = new Point(81, 263);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new Size(59, 15);
            lblProgresso.TabIndex = 8;
            lblProgresso.Text = "Progresso";
            // 
            // lblTempoFormatado
            // 
            lblTempoFormatado.AutoSize = true;
            lblTempoFormatado.Location = new Point(81, 308);
            lblTempoFormatado.Name = "lblTempoFormatado";
            lblTempoFormatado.Size = new Size(57, 15);
            lblTempoFormatado.TabIndex = 9;
            lblTempoFormatado.Text = "Tempo(s)";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(549, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Pausar / Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNomePrograma
            // 
            lblNomePrograma.AutoSize = true;
            lblNomePrograma.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomePrograma.Location = new Point(269, 35);
            lblNomePrograma.Name = "lblNomePrograma";
            lblNomePrograma.Size = new Size(244, 32);
            lblNomePrograma.TabIndex = 11;
            lblNomePrograma.Text = "Micro Ondas Franco";
            lblNomePrograma.TextAlign = ContentAlignment.TopCenter;
            lblNomePrograma.Click += lblNomePrograma_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(lblNomePrograma);
            Controls.Add(btnCancelar);
            Controls.Add(lblTempoFormatado);
            Controls.Add(lblProgresso);
            Controls.Add(lblStatus);
            Controls.Add(lblInfo);
            Controls.Add(progressBar1);
            Controls.Add(btnIniciar);
            Controls.Add(lblPotencia);
            Controls.Add(txtPotencia);
            Controls.Add(lblTempo);
            Controls.Add(txtTempo);
            KeyPreview = true;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Micro Ondas Franco";
            Load += this.FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTempo;
        private Label lblTempo;
        private Label lblPotencia;
        private TextBox txtPotencia;
        private Button btnIniciar;
        private ProgressBar progressBar1;
        private Label lblInfo;
        private Label lblStatus;
        private Label lblProgresso;
        private Label lblTempoFormatado;
        private Button btnCancelar;
        private Label lblNomePrograma;
    }
}
