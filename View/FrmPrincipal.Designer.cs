﻿namespace chat_aps.View
{
    partial class FrmPrincipal
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
            this.PnlFundo = new System.Windows.Forms.Panel();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblOpcoes = new System.Windows.Forms.Label();
            this.LblBoasVindas = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFundo
            // 
            this.PnlFundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlFundo.BackColor = System.Drawing.Color.White;
            this.PnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFundo.Controls.Add(this.BtnCriar);
            this.PnlFundo.Controls.Add(this.BtnEntrar);
            this.PnlFundo.Controls.Add(this.LblOpcoes);
            this.PnlFundo.Controls.Add(this.LblBoasVindas);
            this.PnlFundo.Location = new System.Drawing.Point(12, 104);
            this.PnlFundo.Name = "PnlFundo";
            this.PnlFundo.Size = new System.Drawing.Size(560, 264);
            this.PnlFundo.TabIndex = 0;
            // 
            // BtnCriar
            // 
            this.BtnCriar.BackColor = System.Drawing.Color.Brown;
            this.BtnCriar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.BtnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriar.ForeColor = System.Drawing.Color.White;
            this.BtnCriar.Location = new System.Drawing.Point(112, 197);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(331, 40);
            this.BtnCriar.TabIndex = 3;
            this.BtnCriar.Text = "Criar uma nova sala";
            this.BtnCriar.UseVisualStyleBackColor = false;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(112, 132);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(331, 40);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.Text = "Entrar em um sala";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblOpcoes
            // 
            this.LblOpcoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpcoes.Location = new System.Drawing.Point(-1, 85);
            this.LblOpcoes.Name = "LblOpcoes";
            this.LblOpcoes.Size = new System.Drawing.Size(556, 23);
            this.LblOpcoes.TabIndex = 1;
            this.LblOpcoes.Text = "Você deseja criar uma sala ou entrar em uma sala?";
            this.LblOpcoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBoasVindas
            // 
            this.LblBoasVindas.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoasVindas.Location = new System.Drawing.Point(-1, 26);
            this.LblBoasVindas.Name = "LblBoasVindas";
            this.LblBoasVindas.Size = new System.Drawing.Size(556, 35);
            this.LblBoasVindas.TabIndex = 0;
            this.LblBoasVindas.Text = "Olá, seja bem-vindo!";
            this.LblBoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitulo.Location = new System.Drawing.Point(12, 5);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(560, 96);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "C\\ Chat";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(584, 380);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C\\ - Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFundo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblOpcoes;
        private System.Windows.Forms.Label LblBoasVindas;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.Button BtnEntrar;
    }
}