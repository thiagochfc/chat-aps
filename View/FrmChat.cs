using chat_aps.Model;
using System;
using System.Windows.Forms;

namespace chat_aps.View
{
    public partial class FrmChat : Form
    {

        Cliente Cliente;

        public FrmChat()
        {
            InitializeComponent();
            PnlConteudo.Enabled = false;
            BtnSair.Enabled = false;
        }

        private void FrmChat_Load(object sender, System.EventArgs e)
        {
            // Instância o objeto Cliente
            Cliente = new Cliente(this, TxtUsuario, TxtIP, TxtLog, TxtMensagem);
            // Na saida da aplicação : desconectar
            Application.ApplicationExit += new EventHandler(Cliente.OnApplicationExit);
            Application.ApplicationExit += new EventHandler(Fechar.OnApplicationExit);
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            if (TxtUsuario.Text.Trim().Equals(string.Empty) || TxtIP.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informações inválidas!");
                return;
            }
            Cliente.InicializaConexao();
            ComponentesQuandoIniciado();
            AjusteNaInformacao();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Cliente.FechaConexao("Desconectado a pedido do usuário!");
            ComponentesQuandoFechado();
        }

        private void BtnEnviar_Click(object sender, System.EventArgs e)
        {
            Cliente.EnviaMensagem();
            TxtMensagem.Focus();
        }

        private void TxtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                Cliente.EnviaMensagem();
        }

        private void ComponentesQuandoFechado()
        {
            TxtUsuario.Enabled = true;
            TxtIP.Enabled = true;
            BtnEntrar.Enabled = true;
            BtnSair.Enabled = false;
            PnlConteudo.Enabled = false;
            TxtUsuario.Focus();
        }

        private void ComponentesQuandoIniciado()
        {
            TxtLog.Clear();
            TxtUsuario.Enabled = false;
            TxtIP.Enabled = false;
            BtnEntrar.Enabled = false;
            BtnSair.Enabled = true;
            PnlConteudo.Enabled = true;
            TxtMensagem.Focus();
        }

        internal void IniciaConexaoPelaSala(string txtUsuario, string txtIP)
        {
            TxtUsuario.Text = txtUsuario;
            TxtIP.Text = txtIP;
            BtnEntrar_Click(this, new EventArgs());
            ComponentesQuandoIniciado();
        }

        private void AjusteNaInformacao()
        {
            LblMeuIPMsg.Text = MeuIP.IPv4().ToString();
            LblIPSalaMsg.Text = TxtIP.Text;
        }
    }
}
