﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Scrooge
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

        public RPC (string id)
        {
            ID = id;
        }
        public RPC
            (
                string id, string details, string state, DateTimeOffset startUnix, DateTimeOffset endUnix,
                string largeImage, string largeImageText, string smallImage, string smallImageText
            ) : this(id)
        {
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
    }
}
