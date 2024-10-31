using System;
using Server;
using Server.Commands;
using Server.Mobiles;
using Server.Network;

namespace Server.Commands
{
    public class RunawayCommand
    {
        public static void Initialize()
        {
            CommandSystem.Register("bankrun", AccessLevel.Player, new CommandEventHandler(Runaway_OnCommand));
        }

        [Usage("runaway")]
        [Description("Instantly teleports you to a predefined location and displays a message.")]
        public static void Runaway_OnCommand(CommandEventArgs e)
        {

            Mobile from = e.Mobile;

            // Teleport the player to the coordinates (1323, 1624, 55) in Trammel
            Point3D location = new Point3D(3440, 3440, 0);
            Map map = Map.Sosaria;

            from.MoveToWorld(location, map);

            // Display the message
            from.SendMessage("To the BANK!");
        }
    }
}
