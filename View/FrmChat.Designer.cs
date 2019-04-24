﻿namespace chat_aps.View
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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.LblIP = new System.Windows.Forms.Label();
            this.TxtUsuário = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.SpcConteudo = new System.Windows.Forms.SplitContainer();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlPrincipal.SuspendLayout();
            this.PnlConteudo.SuspendLayout();
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcConteudo)).BeginInit();
            this.SpcConteudo.Panel1.SuspendLayout();
            this.SpcConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(860, 119);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "C\\ Chat";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.PnlConteudo);
            this.PnlPrincipal.Controls.Add(this.PnlLogin);
            this.PnlPrincipal.Location = new System.Drawing.Point(13, 132);
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
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.White;
            this.PnlLogin.Controls.Add(this.BtnSair);
            this.PnlLogin.Controls.Add(this.BtnEntrar);
            this.PnlLogin.Controls.Add(this.TxtIP);
            this.PnlLogin.Controls.Add(this.LblIP);
            this.PnlLogin.Controls.Add(this.TxtUsuário);
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
            // TxtUsuário
            // 
            this.TxtUsuário.BackColor = System.Drawing.Color.White;
            this.TxtUsuário.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuário.Location = new System.Drawing.Point(15, 34);
            this.TxtUsuário.Name = "TxtUsuário";
            this.TxtUsuário.Size = new System.Drawing.Size(411, 27);
            this.TxtUsuário.TabIndex = 0;
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
            this.SpcConteudo.Panel1.Controls.Add(this.button1);
            this.SpcConteudo.Panel1.Controls.Add(this.textBox1);
            this.SpcConteudo.Panel1.Controls.Add(this.TxtLog);
            // 
            // SpcConteudo.Panel2
            // 
            this.SpcConteudo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SpcConteudo.Size = new System.Drawing.Size(852, 462);
            this.SpcConteudo.SplitterDistance = 609;
            this.SpcConteudo.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 429);
            this.textBox1.MaxLength = 500;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(511, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C\\ - Chat";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlConteudo.ResumeLayout(false);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.SpcConteudo.Panel1.ResumeLayout(false);
            this.SpcConteudo.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcConteudo)).EndInit();
            this.SpcConteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.TextBox TxtUsuário;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Panel PnlConteudo;
        private System.Windows.Forms.SplitContainer SpcConteudo;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}