using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_aps.Model
{
    static class Mensagem
    {

        private static void Message(string message)
        {
            MessageBox.Show(message, "C\\ Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageError(string message)
        {
            Message(message);
        }

        public static void MessageInfo(string message)
        {
            Message(message);
        }

        

    }
}
