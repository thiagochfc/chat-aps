namespace chat_aps.View
{
    partial class FrmSala
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
            this.LblSala = new System.Windows.Forms.Label();
            this.PnlConexao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblStatusMensagem = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnParar = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.RbtIPManual = new System.Windows.Forms.RadioButton();
            this.RbtIPAutomatico = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblIP = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PnlConexao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitulo.Location = new System.Drawing.Point(12, 101);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(509, 119);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "C\\ Chat";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSala
            // 
            this.LblSala.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSala.ForeColor = System.Drawing.Color.Brown;
            this.LblSala.Location = new System.Drawing.Point(12, 9);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(510, 92);
            this.LblSala.TabIndex = 4;
            this.LblSala.Text = "Sala";
            this.LblSala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlConexao
            // 
            this.PnlConexao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PnlConexao.Controls.Add(this.panel1);
            this.PnlConexao.Controls.Add(this.BtnParar);
            this.PnlConexao.Controls.Add(this.BtnIniciar);
            this.PnlConexao.Controls.Add(this.RbtIPManual);
            this.PnlConexao.Controls.Add(this.RbtIPAutomatico);
            this.PnlConexao.Controls.Add(this.textBox2);
            this.PnlConexao.Controls.Add(this.textBox1);
            this.PnlConexao.Controls.Add(this.LblIP);
            this.PnlConexao.Controls.Add(this.LblUsuario);
            this.PnlConexao.Location = new System.Drawing.Point(13, 243);
            this.PnlConexao.Name = "PnlConexao";
            this.PnlConexao.Size = new System.Drawing.Size(509, 278);
            this.PnlConexao.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LblStatusMensagem);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Location = new System.Drawing.Point(23, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 54);
            this.panel1.TabIndex = 6;
            // 
            // LblStatusMensagem
            // 
            this.LblStatusMensagem.AutoSize = true;
            this.LblStatusMensagem.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusMensagem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusMensagem.ForeColor = System.Drawing.Color.Black;
            this.LblStatusMensagem.Location = new System.Drawing.Point(91, 13);
            this.LblStatusMensagem.Name = "LblStatusMensagem";
            this.LblStatusMensagem.Size = new System.Drawing.Size(0, 29);
            this.LblStatusMensagem.TabIndex = 7;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.Color.Black;
            this.LblStatus.Location = new System.Drawing.Point(3, 13);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(82, 29);
            this.LblStatus.TabIndex = 6;
            this.LblStatus.Text = "Status:";
            // 
            // BtnParar
            // 
            this.BtnParar.BackColor = System.Drawing.Color.Brown;
            this.BtnParar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.BtnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnParar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParar.ForeColor = System.Drawing.Color.White;
            this.BtnParar.Location = new System.Drawing.Point(263, 184);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(220, 30);
            this.BtnParar.TabIndex = 5;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseVisualStyleBackColor = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.SlateGray;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(23, 184);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(220, 30);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            // 
            // RbtIPManual
            // 
            this.RbtIPManual.AutoSize = true;
            this.RbtIPManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtIPManual.ForeColor = System.Drawing.Color.White;
            this.RbtIPManual.Location = new System.Drawing.Point(23, 154);
            this.RbtIPManual.Name = "RbtIPManual";
            this.RbtIPManual.Size = new System.Drawing.Size(92, 23);
            this.RbtIPManual.TabIndex = 3;
            this.RbtIPManual.TabStop = true;
            this.RbtIPManual.Text = "IP Manual";
            this.RbtIPManual.UseVisualStyleBackColor = true;
            // 
            // RbtIPAutomatico
            // 
            this.RbtIPAutomatico.AutoSize = true;
            this.RbtIPAutomatico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtIPAutomatico.ForeColor = System.Drawing.Color.White;
            this.RbtIPAutomatico.Location = new System.Drawing.Point(23, 125);
            this.RbtIPAutomatico.Name = "RbtIPAutomatico";
            this.RbtIPAutomatico.Size = new System.Drawing.Size(117, 23);
            this.RbtIPAutomatico.TabIndex = 2;
            this.RbtIPAutomatico.TabStop = true;
            this.RbtIPAutomatico.Text = "IP Automático";
            this.RbtIPAutomatico.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 27);
            this.textBox1.TabIndex = 0;
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIP.ForeColor = System.Drawing.Color.White;
            this.LblIP.Location = new System.Drawing.Point(19, 70);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(72, 19);
            this.LblIP.TabIndex = 1;
            this.LblIP.Text = "IP da Sala";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(19, 4);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(119, 19);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Nome de usuário";
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(534, 533);
            this.Controls.Add(this.PnlConexao);
            this.Controls.Add(this.LblSala);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C\\ - Sala";
            this.PnlConexao.ResumeLayout(false);
            this.PnlConexao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Panel PnlConexao;
        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblStatusMensagem;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.RadioButton RbtIPManual;
        private System.Windows.Forms.RadioButton RbtIPAutomatico;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}