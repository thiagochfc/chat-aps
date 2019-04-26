using chat_aps.Model;
using System;
using System.Net;
using System.Windows.Forms;

namespace chat_aps.View
{
    public partial class FrmSala : Form
    {

        FrmChat Chat;

        public FrmSala()
        {
            InitializeComponent();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            // Avisa que o servidor está parado
            LblStatusMensagem.Text = "Parado";
            RbtIPAutomatico.Checked = true;
            Chat = new FrmChat();
        }

        private void BtnIniciar_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Analisa o endereço IP do servidor informado no textbox
                IPAddress EnderecoIP = IPAddress.Parse(TxtIP.Text);

                // Cria uma nova instância do objeto ChatServidor
                Servidor Servidor = new Servidor(EnderecoIP);

                // Inicia o atendimento das conexões
                Servidor.IniciaAtendimento();

                // Inicia o chat automáticamente
                Chat.Show();
                Chat.IniciaConexaoPelaSala(TxtUsuario.Text.Trim(), TxtIP.Text.Trim());

                // Avisa que o servidor está ativo
                LblStatusMensagem.Text = "Iniciado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão : " + ex.Message);
            }
        }

        private void RbtIPAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if(RbtIPAutomatico.Checked)
            {
                try
                {
                    TxtIP.Clear();
                    TxtIP.Text = MeuIP.IPv4().ToString().Trim();
                    TxtIP.Enabled = false;
                } catch(Exception)
                {
                    TxtIP.Enabled = true;
                    RbtIPAutomatico.Enabled = false;
                    RbtIPManual.Checked = true;
                }
            }
        }

        private void RbtIPManual_CheckedChanged(object sender, EventArgs e)
        {
            if(RbtIPManual.Checked)
            {
                TxtIP.Clear();
                TxtIP.Enabled = true;
            }
        }
    }
}
