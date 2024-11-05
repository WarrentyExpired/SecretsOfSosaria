using Server.Mobiles;

namespace Server.Custom
{
    public static class CustomClasses
    {
        public static TroubadourSpecialization Troubadour = new TroubadourSpecialization();
        public static SorcererSpecialization Sorcerer = new SorcererSpecialization();
        //public static AlchemistSpecialization Troubadour = new AlchemistSpecialization();

        public static bool Activate(PlayerMobile player)
        {
            return CustomClasses.Troubadour.Activate(player)
                || CustomClasses.Sorcerer.Activate(player);
                //|| CustomClasses.Alchemist.Activate(player);
        }
    }
}
