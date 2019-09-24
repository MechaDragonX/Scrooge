using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using DiscordRPC;

namespace Scrooge
{
    public static class Client
    {
        private static DiscordRpcClient client;

        public static bool Start(string id)
        {
            client = new DiscordRpcClient(id);
            client.Initialize();
            return client.IsInitialized;
        }
        public static void Update()
        {
            client.Invoke();
        }

        public static void SetPresence(string details, string state)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
            });
        }
        public static void SetPresence(string details, string state, string largeImageKey)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey
                }
            });
        }
        public static void SetPresence(string details, string state, string largeImageKey, string largeImageText)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                }
            });
        }
        public static void SetPresence(string details, string state, string largeImageKey, string largeImageText, string smallimageKey)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                    SmallImageKey = smallimageKey
                }
            });
        }
        public static void SetPresence(string details, string state, string largeImageKey, string largeImageText, string smallimageKey, string smallImageText)
        {
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                    SmallImageKey = smallimageKey,
                    SmallImageText = smallImageText
                }
            });
        }

        public static void End()
        {
            client.Dispose();
        }
    }
}
