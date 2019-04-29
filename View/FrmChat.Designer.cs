namespace chat_aps.View
{
    partial class FrmChat
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlConteudo = new System.Windows.Forms.Panel();
            this.SpcConteudo = new System.Windows.Forms.SplitContainer();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.SpcInformacao = new System.Windows.Forms.SplitContainer();
            this.LblVersaoMsg = new System.Windows.Forms.Label();
            this.LblVersao = new System.Windows.Forms.Label();
            this.LblIPSalaMsg = new System.Windows.Forms.Label();
            this.LblIPSala = new System.Windows.Forms.Label();
            this.LblMeuIPMsg = new System.Windows.Forms.Label();
            this.LblMeuIP = new System.Windows.Forms.Label();
            this.LblInformacoes = new System.Windows.Forms.Label();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.LblIP = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PnlPrincipal.SuspendLayout();
            this.PnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcConteudo)).BeginInit();
            this.SpcConteudo.Panel1.SuspendLayout();
            this.SpcConteudo.Panel2.SuspendLayout();
            this.SpcConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcInformacao)).BeginInit();
            this.SpcInformacao.Panel2.SuspendLayout();
            this.SpcInformacao.SuspendLayout();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitulo.Location = new System.Drawing.Point(9, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(860, 90);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "C\\ Chat";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PnlPrincipal.Controls.Add(this.PnlConteudo);
            this.PnlPrincipal.Controls.Add(this.PnlLogin);
            this.PnlPrincipal.Location = new System.Drawing.Point(13, 102);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(859, 617);
            this.PnlPrincipal.TabIndex = 3;
            // 
            // PnlConteudo
            // 
            this.PnlConteudo.Controls.Add(this.SpcConteudo);
            this.PnlConteudo.Location = new System.Drawing.Point(4, 152);
            this.PnlConteudo.Name = "PnlConteudo";
            this.PnlConteudo.Size = new System.Drawing.Size(852, 462);
            this.PnlConteudo.TabIndex = 1;
            // 
            // SpcConteudo
            // 
            this.SpcConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SpcConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcConteudo.IsSplitterFixed = true;
            this.SpcConteudo.Location = new System.Drawing.Point(0, 0);
            this.SpcConteudo.Name = "SpcConteudo";
            // 
            // SpcConteudo.Panel1
            // 
            this.SpcConteudo.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SpcConteudo.Panel1.Controls.Add(this.BtnEnviar);
            this.SpcConteudo.Panel1.Controls.Add(this.TxtMensagem);
            this.SpcConteudo.Panel1.Controls.Add(this.TxtLog);
            // 
            // SpcConteudo.Panel2
            // 
            this.SpcConteudo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SpcConteudo.Panel2.Controls.Add(this.SpcInformacao);
            this.SpcConteudo.Size = new System.Drawing.Size(852, 462);
            this.SpcConteudo.SplitterDistance = 609;
            this.SpcConteudo.TabIndex = 0;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.SlateGray;
            this.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(511, 429);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(97, 30);
            this.BtnEnviar.TabIndex = 2;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensagem.Location = new System.Drawing.Point(-1, 432);
            this.TxtMensagem.MaxLength = 500;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(506, 27);
            this.TxtMensagem.TabIndex = 1;
            this.TxtMensagem.WordWrap = false;
            this.TxtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMensagem_KeyPress);
            // 
            // TxtLog
            // 
            this.TxtLog.BackColor = System.Drawing.Color.White;
            this.TxtLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLog.Location = new System.Drawing.Point(0, 0);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(608, 423);
            this.TxtLog.TabIndex = 0;
            // 
            // SpcInformacao
            // 
            this.SpcInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcInformacao.IsSplitterFixed = true;
            this.SpcInformacao.Location = new System.Drawing.Point(0, 0);
            this.SpcInformacao.Name = "SpcInformacao";
            this.SpcInformacao.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcInformacao.Panel2
            // 
            this.SpcInformacao.Panel2.Controls.Add(this.LblVersaoMsg);
            this.SpcInformacao.Panel2.Controls.Add(this.LblVersao);
            this.SpcInformacao.Panel2.Controls.Add(this.LblIPSalaMsg);
            this.SpcInformacao.Panel2.Controls.Add(this.LblIPSala);
            this.SpcInformacao.Panel2.Controls.Add(this.LblMeuIPMsg);
            this.SpcInformacao.Panel2.Controls.Add(this.LblMeuIP);
            this.SpcInformacao.Panel2.Controls.Add(this.LblInformacoes);
            this.SpcInformacao.Size = new System.Drawing.Size(239, 462);
            this.SpcInformacao.SplitterDistance = 260;
            this.SpcInformacao.TabIndex = 0;
            // 
            // LblVersaoMsg
            // 
            this.LblVersaoMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersaoMsg.ForeColor = System.Drawing.Color.White;
            this.LblVersaoMsg.Location = new System.Drawing.Point(124, 169);
            this.LblVersaoMsg.Name = "LblVersaoMsg";
            this.LblVersaoMsg.Size = new System.Drawing.Size(112, 19);
            this.LblVersaoMsg.TabIndex = 6;
            this.LblVersaoMsg.Text = "1.0.0";
            // 
            // LblVersao
            // 
            this.LblVersao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersao.ForeColor = System.Drawing.Color.White;
            this.LblVersao.Location = new System.Drawing.Point(7, 169);
            this.LblVersao.Name = "LblVersao";
            this.LblVersao.Size = new System.Drawing.Size(112, 19);
            this.LblVersao.TabIndex = 5;
            this.LblVersao.Text = "Versão:";
            this.LblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblIPSalaMsg
            // 
            this.LblIPSalaMsg.AutoSize = true;
            this.LblIPSalaMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIPSalaMsg.ForeColor = System.Drawing.Color.White;
            this.LblIPSalaMsg.Location = new System.Drawing.Point(8, 129);
            this.LblIPSalaMsg.Name = "LblIPSalaMsg";
            this.LblIPSalaMsg.Size = new System.Drawing.Size(53, 19);
            this.LblIPSalaMsg.TabIndex = 4;
            this.LblIPSalaMsg.Text = "0.0.0.0";
            // 
            // LblIPSala
            // 
            this.LblIPSala.AutoSize = true;
            this.LblIPSala.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIPSala.ForeColor = System.Drawing.Color.White;
            this.LblIPSala.Location = new System.Drawing.Point(7, 105);
            this.LblIPSala.Name = "LblIPSala";
            this.LblIPSala.Size = new System.Drawing.Size(72, 19);
            this.LblIPSala.TabIndex = 3;
            this.LblIPSala.Text = "IP da Sala";
            // 
            // LblMeuIPMsg
            // 
            this.LblMeuIPMsg.AutoSize = true;
            this.LblMeuIPMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeuIPMsg.ForeColor = System.Drawing.Color.White;
            this.LblMeuIPMsg.Location = new System.Drawing.Point(7, 72);
            this.LblMeuIPMsg.Name = "LblMeuIPMsg";
            this.LblMeuIPMsg.Size = new System.Drawing.Size(53, 19);
            this.LblMeuIPMsg.TabIndex = 2;
            this.LblMeuIPMsg.Text = "0.0.0.0";
            // 
            // LblMeuIP
            // 
            this.LblMeuIP.AutoSize = true;
            this.LblMeuIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeuIP.ForeColor = System.Drawing.Color.White;
            this.LblMeuIP.Location = new System.Drawing.Point(7, 48);
            this.LblMeuIP.Name = "LblMeuIP";
            this.LblMeuIP.Size = new System.Drawing.Size(54, 19);
            this.LblMeuIP.TabIndex = 1;
            this.LblMeuIP.Text = "Meu IP";
            // 
            // LblInformacoes
            // 
            this.LblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacoes.ForeColor = System.Drawing.Color.White;
            this.LblInformacoes.Location = new System.Drawing.Point(3, 0);
            this.LblInformacoes.Name = "LblInformacoes";
            this.LblInformacoes.Size = new System.Drawing.Size(233, 23);
            this.LblInformacoes.TabIndex = 0;
            this.LblInformacoes.Text = "Informações";
            this.LblInformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.White;
            this.PnlLogin.Controls.Add(this.BtnSair);
            this.PnlLogin.Controls.Add(this.BtnEntrar);
            this.PnlLogin.Controls.Add(this.TxtIP);
            this.PnlLogin.Controls.Add(this.LblIP);
            this.PnlLogin.Controls.Add(this.TxtUsuario);
            this.PnlLogin.Controls.Add(this.LblUsuario);
            this.PnlLogin.Location = new System.Drawing.Point(4, 4);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(608, 141);
            this.PnlLogin.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Brown;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(432, 82);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(162, 40);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(432, 34);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(162, 40);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtIP
            // 
            this.TxtIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIP.Location = new System.Drawing.Point(15, 95);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(411, 27);
            this.TxtIP.TabIndex = 1;
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIP.Location = new System.Drawing.Point(15, 73);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(72, 19);
            this.LblIP.TabIndex = 2;
            this.LblIP.Text = "IP da sala";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(15, 34);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(411, 27);
            this.TxtUsuario.TabIndex = 0;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(15, 12);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(119, 19);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Nome de usuário";
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(884, 726);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C\\ - Chat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlConteudo.ResumeLayout(false);
            this.SpcConteudo.Panel1.ResumeLayout(false);
            this.SpcConteudo.Panel1.PerformLayout();
            this.SpcConteudo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcConteudo)).EndInit();
            this.SpcConteudo.ResumeLayout(false);
            this.SpcInformacao.Panel2.ResumeLayout(false);
            this.SpcInformacao.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcInformacao)).EndInit();
            this.SpcInformacao.ResumeLayout(false);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Panel PnlConteudo;
        private System.Windows.Forms.SplitContainer SpcConteudo;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.SplitContainer SpcInformacao;
        private System.Windows.Forms.Label LblVersaoMsg;
        private System.Windows.Forms.Label LblVersao;
        private System.Windows.Forms.Label LblIPSalaMsg;
        private System.Windows.Forms.Label LblIPSala;
        private System.Windows.Forms.Label LblMeuIPMsg;
        private System.Windows.Forms.Label LblMeuIP;
        private System.Windows.Forms.Label LblInformacoes;
        private System.Windows.Forms.TextBox TxtLog;
    }
}