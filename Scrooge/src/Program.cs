using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Principal;
using DiscordRPC;

namespace Scrooge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static bool StartClient(string id)
        {
            DiscordRpcClient Client = new DiscordRpcClient(id);
            Client.Initialize();
            return Client.IsInitialized;
        }
    }
}
