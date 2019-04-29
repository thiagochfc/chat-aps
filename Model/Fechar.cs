using System;
using System.Diagnostics;

namespace chat_aps.Model
{
    static class Fechar
    {
        public static void OnApplicationExit(object sender, EventArgs e)
        {
            var process = Process.GetProcessesByName("chat-aps.exe");
            foreach (var p in process)
            {
                p.Kill();
                p.WaitForExit();
            }
        }
    }
}
