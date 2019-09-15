using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DotnetRPC;

namespace ScroogeDesktop
{
    public class RPC
    {
        public static string ID { get; set; }
        public static string Details { get; set; }
        public static string State { get; set; }
        public static DateTimeOffset StartUnix { get; set; }
        public static DateTimeOffset EndUnix { get; set; }
        public static string LargeImage { get; set; }
        public static string LargeImageText { get; set; }
        public static string SmallImage { get; set; }
        public static string SmallImageText { get; set; }
        public static bool HasParty { get; set; }
        public static int CurrentPartySize { get; set; }
        public static int MaxPartySize { get; set; }
        public static string PartyID { get; set; }

        public RPC
            (
                string id, string details, string state, DateTimeOffset startUnix, DateTimeOffset endUnix,
                string largeImage, string largeImageText, string smallImage, string smallImageText
            )
        {
            ID = id;
            Details = details;
            State = state;
            StartUnix = startUnix;
            EndUnix = endUnix;
            LargeImage = largeImage;
            LargeImageText = largeImageText;
            SmallImage = smallImage;
            SmallImageText = smallImageText;

            HasParty = false;
        }
        public RPC
            (
                string id, string details, string state, DateTimeOffset startUnix, DateTimeOffset endUnix,
                string largeImage, string largeImageText, string smallImage, string smallImageText,
                int currentPartySize, int maxPartySize, string partyId
            )
            : this(id, details, state, startUnix, endUnix, largeImage, largeImageText, smallImage, smallImageText)
        {
            HasParty = true;

            CurrentPartySize = currentPartySize;
            MaxPartySize = maxPartySize;
            PartyID = partyId;
        }

        public static async Task StartAsync(bool admin)
        {
            var client = new RpcClient(ID, admin, Assembly.GetExecutingAssembly().Location);
            client.ConnectionClosed += _ =>
            {
                Console.WriteLine("Disconnected!");
                return Task.CompletedTask;
            };
            client.ClientErrored += args =>
            {
                Console.WriteLine($"Client error: {args.Exception}");
                return Task.CompletedTask;
            };
            client.Ready += async args =>
            {
                // Only start on ready
                await client.SetActivityAsync(x =>
                {
                    x.Details = Details;
                    x.State = State;
                    x.StartUnix = StartUnix;
                    x.EndUnix = DateTimeOffset.Now.AddHours(24);

                    x.LargeImage = LargeImage;
                    x.LargeImageText = LargeImageText;

                    x.SmallImage = SmallImage;
                    x.SmallImageText = SmallImageText;

                    if (HasParty)
                    {
                        x.CurrentPartySize = CurrentPartySize;
                        x.MaxPartySize = MaxPartySize;
                        x.PartyId = PartyID;
                    }
                });
            };

            await client.ConnectAsync();

            await Task.Delay(15000);
            client.Dispose();
            Console.WriteLine("It's gone!");
            Console.ReadKey();
        }
    }
}
