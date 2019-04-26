using System;
using System.Net;

namespace chat_aps.Model
{
    static class MeuIP
    {

        public static IPAddress[] IP { get; set; }

        public static IPAddress IPv4()
        {
            string nome = Dns.GetHostName();
            IP = Dns.GetHostAddresses(nome);
            return TratamentoDoIP(IP);
        }

        private static IPAddress TratamentoDoIP(IPAddress[] ip)
        {
            if (ip[1].ToString().Length <= 15)
                return ip[1];
            else if (ip[3].ToString().Length <= 15)
                return ip[3];
            else
                throw new Exception();
        }

    }
}
