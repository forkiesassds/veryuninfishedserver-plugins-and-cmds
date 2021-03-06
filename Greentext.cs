using System;
using System.IO;
using MCGalaxy;
using MCGalaxy.Events.PlayerEvents;
using MCGalaxy.Modules.Relay.Discord;

namespace Core {
 	public class Greentext : Plugin {

		public override string creator { get { return "icanttellyou"; } }
		public override string MCGalaxy_Version { get { return "1.0.1"; } }
		public override string name { get { return "Greentext"; } }

		public override void Load(bool startup) {
		    OnPlayerChatEvent.Register(InterceptChat, Priority.High);
		}
		public override void Unload(bool shutdown) {
		    OnPlayerChatEvent.Unregister(InterceptChat);
		}
		static void InterceptChat(Player p, string message) {
		    if (message.StartsWith(">")) 
		    {
				Chat.MessageChat(p, "λFULL: &a" + message, null, true);
				p.cancelchat = true;
		    }
		}
    }
}
