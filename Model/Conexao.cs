using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace chat_aps.Model
{
    class Conexao
    {
        TcpClient TcpCliente;
        // A thread que ira enviar a informação para o cliente
        private Thread ThrSender;
        private StreamReader SrReceptor;
        private StreamWriter SwEnviador;
        private string UsuarioAtual;
        private string StrResposta;

        // O construtor da classe que que toma a conexão TCP
        public Conexao(TcpClient tcpCon)
        {
            TcpCliente = tcpCon;
            // A thread que aceita o cliente e espera a mensagem
            ThrSender = new Thread(AceitaCliente);
            // A thread chama o método AceitaCliente()
            ThrSender.Start();
        }

        private void FechaConexao()
        {
            // Fecha os objetos abertos
            TcpCliente.Close();
            SrReceptor.Close();
            SwEnviador.Close();
        }

        // Ocorre quando um novo cliente é aceito
        private void AceitaCliente()
        {
            SrReceptor = new StreamReader(TcpCliente.GetStream());
            SwEnviador = new StreamWriter(TcpCliente.GetStream());

            // Lê a informação da conta do cliente
            UsuarioAtual = SrReceptor.ReadLine();

            // temos uma resposta do cliente
            if (UsuarioAtual != "")
            {
                // Armazena o nome do usuário na hash table
                if (Servidor.HtUsuarios.Contains(UsuarioAtual) == true)
                {
                    // 0 => significa não conectado
                    SwEnviador.WriteLine("0|Este nome de usuário já existe.");
                    SwEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else if (UsuarioAtual == "Administrator")
                {
                    // 0 => não conectado
                    SwEnviador.WriteLine("0|Este nome de usuário é reservado.");
                    SwEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    // 1 => conectou com sucesso
                    SwEnviador.WriteLine("1");
                    SwEnviador.Flush();

                    // Inclui o usuário na hash table e inicia a escuta de suas mensagens
                    Servidor.IncluiUsuario(TcpCliente, UsuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }
            //
            try
            {
                // Continua aguardando por uma mensagem do usuário
                while ((StrResposta = SrReceptor.ReadLine()) != "")
                {
                    // Se for inválido remove-o
                    if (StrResposta == null)
                        Servidor.RemoveUsuario(TcpCliente);
                    else
                        // envia a mensagem para todos os outros usuários
                        Servidor.EnviaMensagem(UsuarioAtual, StrResposta);
                }
            }
            catch
            {
                // Se houve um problema com este usuário desconecta-o
                Servidor.RemoveUsuario(TcpCliente);
            }
        }
    }
}