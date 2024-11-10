using System;
using System.IO;
using Newtonsoft.Json;
using TShockAPI;

namespace SmarterStarter
{
    public class PluginSettings
    {
        public PluginSettings()
        {
        }

        public static Bosses GetBosses;

        public class Bosses
        {
            public StarterItems.PlayerSettings KingSlime { get; set; }
            public StarterItems.PlayerSettings EyeOfCthulhu { get; set; }
            public StarterItems.PlayerSettings EvilBoss_BOC_EOW { get; set; }
            public StarterItems.PlayerSettings DeerClops { get; set; }
            public StarterItems.PlayerSettings QueenBee { get; set; }
            public StarterItems.PlayerSettings Skeletron { get; set; }
            public StarterItems.PlayerSettings WallOfFlesh { get; set; }
            public StarterItems.PlayerSettings QueenSlime { get; set; }
            public StarterItems.PlayerSettings TheDestoryer_Mech1 { get; set; }
            public StarterItems.PlayerSettings TheTwins_Mech2 { get; set; }
            public StarterItems.PlayerSettings SkeletronPrime_Mech3 { get; set; }
            public StarterItems.PlayerSettings PostMech_AllMechs { get; set; }
            public StarterItems.PlayerSettings DukeFishron { get; set; }
            public StarterItems.PlayerSettings Plantera { get; set; }
            public StarterItems.PlayerSettings EmpressOfLight { get; set; }
            public StarterItems.PlayerSettings Golem { get; set; }
            public StarterItems.PlayerSettings LunaticCultist { get; set; }
            public StarterItems.PlayerSettings MoonLord { get; set; }

            public Bosses()
            {
                KingSlime = new();
                EyeOfCthulhu = new();
                EvilBoss_BOC_EOW = new();
                DeerClops = new();
                QueenBee = new();
                Skeletron = new();
                WallOfFlesh = new();
                QueenSlime = new();
                TheDestoryer_Mech1 = new();
                TheTwins_Mech2 = new();
                SkeletronPrime_Mech3 = new();
                PostMech_AllMechs = new();
                DukeFishron = new();
                Plantera = new();
                EmpressOfLight = new();
                Golem = new();
                LunaticCultist = new();
                MoonLord = new();
            }
            public void FixNull()
            {
                if (KingSlime == null) KingSlime = new();
                if (EyeOfCthulhu == null) EyeOfCthulhu = new();
                if (EvilBoss_BOC_EOW == null) EvilBoss_BOC_EOW = new();
                if (DeerClops == null) DeerClops = new();
                if (QueenBee == null) QueenBee = new();
                if (Skeletron == null) Skeletron = new();
                if (WallOfFlesh == null) WallOfFlesh = new();
                if (QueenSlime == null) QueenSlime = new();
                if (TheDestoryer_Mech1 == null) TheDestoryer_Mech1 = new();
                if (TheTwins_Mech2 == null) TheTwins_Mech2 = new();
                if (SkeletronPrime_Mech3 == null) SkeletronPrime_Mech3 = new();
                if (PostMech_AllMechs == null) PostMech_AllMechs = new();
                if (DukeFishron == null) DukeFishron = new();
                if (Plantera == null) Plantera = new();
                if (EmpressOfLight == null) EmpressOfLight = new();
                if (Golem == null) Golem = new();
                if (LunaticCultist == null) LunaticCultist = new();
                if (MoonLord == null) MoonLord = new();

                KingSlime.FixNull();
                EyeOfCthulhu.FixNull();
                EvilBoss_BOC_EOW.FixNull();
                DeerClops.FixNull();
                QueenBee.FixNull();
                Skeletron.FixNull();
                WallOfFlesh.FixNull();
                QueenSlime.FixNull();
                TheDestoryer_Mech1.FixNull();
                TheTwins_Mech2.FixNull();
                SkeletronPrime_Mech3.FixNull();
                PostMech_AllMechs.FixNull();
                DukeFishron.FixNull();
                Plantera.FixNull(); ;
                EmpressOfLight.FixNull();
                Golem.FixNull();
                LunaticCultist.FixNull();
                MoonLord.FixNull();
            }
        }

        public static void LoadSettings()
        {
            var path = Path.Combine(TShock.SavePath, "SmarterStarter.json");
            if (!File.Exists(path))
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(new Bosses(), Formatting.Indented));
                GetBosses = new();
                Console.WriteLine("SmarterStarter configuration has been created!");
            }
            else
            {
                Bosses loadedBosses = JsonConvert.DeserializeObject<Bosses>(File.ReadAllText(path));

                GetBosses = loadedBosses;

                Console.WriteLine("SmarterStarter configuration loaded.");
            }
        }
        public static void ReloadSettings()
        {
            var path = Path.Combine(TShock.SavePath, "SmarterStarter.json");
            if (!File.Exists(path))
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(new Bosses(), Formatting.Indented));
                GetBosses = new();
                Console.WriteLine("SmarterStarter configuration has been created!");
            }
            else
            {
                Bosses loadedBosses = JsonConvert.DeserializeObject<Bosses>(File.ReadAllText(path));

                loadedBosses.FixNull();

                GetBosses = loadedBosses;

                Console.WriteLine("SmarterStarter configuration Reloaded.");
            }
        }
    }
}
