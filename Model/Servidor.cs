using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace chat_aps.Model
{
    class Servidor
    {
        // Este delegate é necessário para especificar os parametros que estamos pasando com o nosso evento
        public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
        // Esta hash table armazena os usuários e as conexões (acessado/consultado por usuário)
        public static Hashtable HtUsuarios = new Hashtable(30); // 30 usuarios é o limite definido
        // Esta hash table armazena os usuários e as conexões (acessada/consultada por conexão)
        public static Hashtable HtConexoes = new Hashtable(30); // 30 usuários é o limite definido
        // armazena o endereço IP passado
        private IPAddress EnderecoIP;
        private TcpClient TcpCliente;
        // O evento e o seu argumento irá notificar o formulário quando um usuário se conecta, desconecta, envia uma mensagem,etc
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        // O construtor define o endereço IP para aquele retornado pela instanciação do objeto
        public Servidor(IPAddress endereco)
        {
            EnderecoIP = endereco;
        }

        // A thread que ira tratar o escutador de conexões
        private Thread ThrListener;

        // O objeto TCP object que escuta as conexões
        private TcpListener TlsCliente;

        // Ira dizer ao laço while para manter a monitoração das conexões
        bool ServidorRodando = false;

        // Inclui o usuário nas tabelas hash
        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
        {
            // Primeiro inclui o nome e conexão associada para ambas as hash tables
            HtUsuarios.Add(strUsername, tcpUsuario);
            HtConexoes.Add(tcpUsuario, strUsername);

            // Informa a nova conexão para todos os usuário e para o formulário do servidor
            EnviaMensagemAdmin(HtConexoes[tcpUsuario] + " entrou..");
        }

        // Remove o usuário das tabelas (hash tables)
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            // Se o usuário existir
            if (HtConexoes[tcpUsuario] != null)
            {
                // Primeiro mostra a informação e informa os outros usuários sobre a conexão
                EnviaMensagemAdmin(HtConexoes[tcpUsuario] + " saiu...");

                // Removeo usuário da hash table
                HtUsuarios.Remove(HtConexoes[tcpUsuario]);
                HtConexoes.Remove(tcpUsuario);
            }
        }

        // Este evento é chamado quando queremos disparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;
            if (statusHandler != null)
            {
                // invoca o  delegate
                statusHandler(null, e);
            }
        }

        // Envia mensagens administratias
        public static void EnviaMensagemAdmin(string Mensagem)
        {
            StreamWriter SwSenderSender;

            // Exibe primeiro na aplicação
            e = new StatusChangedEventArgs(Mensagem);
            OnStatusChanged(e);

            // Cria um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[HtUsuarios.Count];
            // Copia os objetos TcpClient no array
            HtUsuarios.Values.CopyTo(tcpClientes, 0);
            // Percorre a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                // Tenta enviar uma mensagem para cada cliente
                try
                {
                    // Se a mensagem estiver em branco ou a conexão for nula sai...
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                        continue;
                    // Envia a mensagem para o usuário atual no laço
                    SwSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    SwSenderSender.WriteLine(Mensagem);
                    SwSenderSender.Flush();
                    SwSenderSender = null;
                }
                catch // Se houver um problema , o usuário não existe , então remove-o
                {
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        // Envia mensagens de um usuário para todos os outros
        public static void EnviaMensagem(string Origem, string Mensagem)
        {
            StreamWriter swSenderSender;

            // Primeiro exibe a mensagem na aplicação
            e = new StatusChangedEventArgs(Origem + " disse : " + Mensagem);
            OnStatusChanged(e);

            // Cria um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] TcpClientes = new TcpClient[HtUsuarios.Count];
            // Copia os objetos TcpClient no array
            HtUsuarios.Values.CopyTo(TcpClientes, 0);
            // Percorre a lista de clientes TCP
            for (int i = 0; i < TcpClientes.Length; i++)
            {
                // Tenta enviar uma mensagem para cada cliente
                try
                {
                    // Se a mensagem estiver em branco ou a conexão for nula sai...
                    if (Mensagem.Trim() == "" || TcpClientes[i] == null)
                        continue;

                    // Envia a mensagem para o usuário atual no laço
                    swSenderSender = new StreamWriter(TcpClientes[i].GetStream());
                    swSenderSender.WriteLine(Origem + " disse: " + Mensagem);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch // Se houver um problema , o usuário não existe , então remove-o
                {
                    RemoveUsuario(TcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento()
        {
            try
            {

                // Pega o IP do primeiro dispostivo da rede
                IPAddress ipaLocal = EnderecoIP;

                // Cria um objeto TCP listener usando o IP do servidor e porta definidas
                TlsCliente = new TcpListener(ipaLocal, 2502);

                // Inicia o TCP listener e escuta as conexões
                TlsCliente.Start();

                // O laço While verifica se o servidor esta rodando antes de checar as conexões
                ServidorRodando = true;

                // Inicia uma nova tread que hospeda o listener
                ThrListener = new Thread(MantemAtendimento);
                ThrListener.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MantemAtendimento()
        {
            // Enquanto o servidor estiver rodando
            while (ServidorRodando == true)
            {
                // Aceita uma conexão pendente
                TcpCliente = TlsCliente.AcceptTcpClient();
                // Cria uma nova instância da conexão
                Conexao newConnection = new Conexao(TcpCliente);
            }
        }
    }
}
