using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace chat_aps.Model
{
    class Cliente
    {
        // Classe usuario
        private Usuario Usuario;
        // Envia a mensagem
        private StreamWriter StwEnviador;
        // Receptor da mensagem
        private StreamReader StrReceptor;
        // Cria uma instância para o Servidor
        private TcpClient TcpServidor;
        // Necessário para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        // Necessário para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        // Thread responsável pela sincrinização
        private Thread MensagemThread;
        // Responsável pelo endereço de IP
        private IPAddress EnderecoIP;
        // Flag para saber se está conectado
        private bool Conectado;

        // Componentes Visuais
        private Form View;
        private TextBox TxtUsuario;
        private TextBox TxtIP;
        private TextBox TxtLog;
        private TextBox TxtMensagem;

        public Cliente() { }

        public Cliente(Form view, TextBox txtUsuario, TextBox txtIP, TextBox txtLog, TextBox txtMensagem)
        {
            View = view;
            TxtUsuario = txtUsuario;
            TxtIP = txtIP;
            TxtLog = txtLog;
            TxtMensagem = txtMensagem;
        }

        internal void InicializaConexao()
        {
            try
            {
                // Trata o endereço IP informado em um objeto IPAdress
                EnderecoIP = IPAddress.Parse(TxtIP.Text);
                // Inicia uma nova conexão TCP com o Servidor do chat
                TcpServidor = new TcpClient();
                TcpServidor.Connect(EnderecoIP, 2502);

                // Ajuda a verificar se estamos conectados ou não
                Conectado = true;

                // Cria um usuário e passa seu nome
                Usuario = new Usuario(TxtUsuario.Text.Trim());

                // Envia o nome do usuário ao servidor
                StwEnviador = new StreamWriter(TcpServidor.GetStream());
                StwEnviador.WriteLine(Usuario.Nome);
                StwEnviador.Flush();

                // Inicia a thread para receber mensagens e nova comunicação
                MensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                MensagemThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro na conexão com servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RecebeMensagens()
        {
            // Recebe a resposta do servidor
            StrReceptor = new StreamReader(TcpServidor.GetStream());
            string ConexaoResposta = StrReceptor.ReadLine();

            // Se o primeiro caracater da resposta é 1 a conexão foi feita com sucesso
            if (ConexaoResposta[0] == '1')
                // Atualiza o formulário para informar que esta conectado
                View.Invoke(new AtualizaLogCallBack(AtualizaLog), new object[] { "Conectado com sucesso!" });
            else // Se o primeiro caractere não for 1 a conexão falhou
            {
                string Motivo = "Não Conectado: ";
                // Extrai o motivo da mensagem resposta. O motivo começa no 3º caractere
                Motivo += ConexaoResposta.Substring(2, ConexaoResposta.Length - 2);
                // Atualiza o formulário como o motivo da falha na conexão
                View.Invoke(new FechaConexaoCallBack(FechaConexao), new object[] { Motivo });
                // Sai do método
                return;
            }
            // Enquanto estiver conectado le as linhas que estão chegando do servidor
            while (Conectado)
                // Exibe mensagems no Textbox
                View.Invoke(new AtualizaLogCallBack(AtualizaLog), new object[] { StrReceptor.ReadLine() });
        }

        private void AtualizaLog(string strMensagem)
        {
            // Anexa texto ao final de cada linha
            TxtLog.AppendText(strMensagem + "\r\n");
        }

        internal void EnviaMensagem()
        {
            if (TxtMensagem.Lines.Length >= 1)
            {
                StwEnviador.WriteLine(TxtMensagem.Text);
                StwEnviador.Flush();
                TxtMensagem.Lines = null;
            }
            TxtMensagem.Text = "";
        }

        internal void FechaConexao(string Motivo)
        {
            // Mostra o motivo porque a conexão encerrou
            TxtLog.AppendText(Motivo + "\r\n");
            
            // Fecha os objetos
            Conectado = false;
            StwEnviador.Close();
            StrReceptor.Close();
            TcpServidor.Close();
        }

        // O tratador de evento para a saida da aplicação
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado == true)
            {
                // Fecha as conexões, streams, etc...
                Conectado = false;
                StwEnviador.Close();
                StrReceptor.Close();
                TcpServidor.Close();
            }
        }
    }
}
