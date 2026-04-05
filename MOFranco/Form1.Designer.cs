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
            btnPipoca = new Button();
            groupBox1 = new GroupBox();
            btnFeijao = new Button();
            btnFrango = new Button();
            btnCarnesdeBoi = new Button();
            btnLeite = new Button();
            groupBox2 = new GroupBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnNovoPrograma = new Button();
            lstProgramas = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            progressBar1.Location = new Point(81, 666);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(579, 23);
            progressBar1.TabIndex = 5;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(81, 337);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(28, 15);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Info";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(81, 194);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            lblStatus.Visible = false;
            // 
            // lblProgresso
            // 
            lblProgresso.AutoSize = true;
            lblProgresso.Location = new Point(81, 370);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new Size(59, 15);
            lblProgresso.TabIndex = 8;
            lblProgresso.Text = "Progresso";
            // 
            // lblTempoFormatado
            // 
            lblTempoFormatado.AutoSize = true;
            lblTempoFormatado.Location = new Point(83, 235);
            lblTempoFormatado.Name = "lblTempoFormatado";
            lblTempoFormatado.Size = new Size(57, 15);
            lblTempoFormatado.TabIndex = 9;
            lblTempoFormatado.Text = "Tempo(s)";
            lblTempoFormatado.Visible = false;
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
            // 
            // btnPipoca
            // 
            btnPipoca.Location = new Point(18, 31);
            btnPipoca.Name = "btnPipoca";
            btnPipoca.Size = new Size(123, 23);
            btnPipoca.TabIndex = 12;
            btnPipoca.Text = "Pipoca";
            btnPipoca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFeijao);
            groupBox1.Controls.Add(btnFrango);
            groupBox1.Controls.Add(btnCarnesdeBoi);
            groupBox1.Controls.Add(btnLeite);
            groupBox1.Controls.Add(btnPipoca);
            groupBox1.Location = new Point(204, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 152);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnFeijao
            // 
            btnFeijao.Location = new Point(85, 110);
            btnFeijao.Name = "btnFeijao";
            btnFeijao.Size = new Size(123, 23);
            btnFeijao.TabIndex = 16;
            btnFeijao.Text = "Feijão";
            btnFeijao.UseVisualStyleBackColor = true;
            // 
            // btnFrango
            // 
            btnFrango.Location = new Point(157, 72);
            btnFrango.Name = "btnFrango";
            btnFrango.Size = new Size(123, 23);
            btnFrango.TabIndex = 15;
            btnFrango.Text = "Frango";
            btnFrango.UseVisualStyleBackColor = true;
            // 
            // btnCarnesdeBoi
            // 
            btnCarnesdeBoi.Location = new Point(18, 72);
            btnCarnesdeBoi.Name = "btnCarnesdeBoi";
            btnCarnesdeBoi.Size = new Size(123, 23);
            btnCarnesdeBoi.TabIndex = 14;
            btnCarnesdeBoi.Text = "Carnes de Boi";
            btnCarnesdeBoi.UseVisualStyleBackColor = true;
            // 
            // btnLeite
            // 
            btnLeite.Location = new Point(157, 31);
            btnLeite.Name = "btnLeite";
            btnLeite.Size = new Size(123, 23);
            btnLeite.TabIndex = 13;
            btnLeite.Text = "Leite";
            btnLeite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnNovoPrograma);
            groupBox2.Location = new Point(519, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(160, 152);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = " Programas Customizados ";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(27, 110);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(114, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 72);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovoPrograma
            // 
            btnNovoPrograma.Location = new Point(27, 31);
            btnNovoPrograma.Name = "btnNovoPrograma";
            btnNovoPrograma.Size = new Size(114, 23);
            btnNovoPrograma.TabIndex = 0;
            btnNovoPrograma.Text = "Novo";
            btnNovoPrograma.UseVisualStyleBackColor = true;
            btnNovoPrograma.Click += btnNovoPrograma_Click;
            // 
            // lstProgramas
            // 
            lstProgramas.FormattingEnabled = true;
            lstProgramas.Location = new Point(694, 173);
            lstProgramas.Name = "lstProgramas";
            lstProgramas.Size = new Size(207, 139);
            lstProgramas.TabIndex = 15;
            lstProgramas.SelectedIndexChanged += lstProgramas_SelectedIndexChanged;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 701);
            Controls.Add(lstProgramas);
            Controls.Add(groupBox2);
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
            Controls.Add(groupBox1);
            KeyPreview = true;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Micro Ondas Franco";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private Button btnPipoca;
        private GroupBox groupBox1;
        private Button btnCarnesdeBoi;
        private Button btnLeite;
        private Button btnFeijao;
        private Button btnFrango;
        private GroupBox groupBox2;
        private Button btnNovoPrograma;
        private Button btnEditar;
        private ListBox lstProgramas;
        private Button btnExcluir;
    }
}
