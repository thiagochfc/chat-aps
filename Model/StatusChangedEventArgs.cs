using System;

namespace chat_aps.Model
{
    class StatusChangedEventArgs : EventArgs
    {
        // Mensagem do evento
        public string EventMsg { get; set; }

        // Construtor para definir a mensagem do evento
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}
