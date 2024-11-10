using System;
using System.Collections.Generic;
using Terraria;
using TShockAPI;

namespace SmarterStarter
{
    public class CheckBosses
    {
        public CheckBosses()
        {
        }

        public static void Check()
        {
            if (NPC.downedMoonlord)
            {
                StarterItems.Set(PluginSettings.GetBosses.MoonLord);
                return;
            }
            if (NPC.downedAncientCultist)
            {
                StarterItems.Set(PluginSettings.GetBosses.LunaticCultist);
                return;
            }
            if (NPC.downedGolemBoss)
            {
                StarterItems.Set(PluginSettings.GetBosses.Golem);
                return;
            }
            if (NPC.downedEmpressOfLight)
            {
                StarterItems.Set(PluginSettings.GetBosses.EmpressOfLight);
                return;
            }
            if (NPC.downedPlantBoss)
            {
                StarterItems.Set(PluginSettings.GetBosses.Plantera);
                return;
            }
            if (NPC.downedFishron)
            {
                StarterItems.Set(PluginSettings.GetBosses.DukeFishron);
                return;
            }
            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                StarterItems.Set(PluginSettings.GetBosses.PostMech_AllMechs);
                return;
            }
            if (NPC.downedMechBoss3) // Skeletron Prime
            {
                StarterItems.Set(PluginSettings.GetBosses.SkeletronPrime_Mech3);
                return;
            }
            if (NPC.downedMechBoss2) // Twins
            {
                StarterItems.Set(PluginSettings.GetBosses.TheTwins_Mech2);
                return;
            }
            if (NPC.downedMechBoss1) // Destroyer
            {
                StarterItems.Set(PluginSettings.GetBosses.TheDestoryer_Mech1);
                return;
            }
            if (NPC.downedQueenSlime)
            {
                StarterItems.Set(PluginSettings.GetBosses.QueenSlime);
                return;
            }
            if (Main.hardMode)
            {
                StarterItems.Set(PluginSettings.GetBosses.WallOfFlesh);
                return;
            }
            if (NPC.downedBoss3) // Skeletron
            {
                StarterItems.Set(PluginSettings.GetBosses.Skeletron);
                return;
            }
            if (NPC.downedQueenBee)
            {
                StarterItems.Set(PluginSettings.GetBosses.QueenBee);
                return;
            }
            if (NPC.downedDeerclops)
            {
                StarterItems.Set(PluginSettings.GetBosses.DeerClops);
                return;
            }
            if (NPC.downedBoss2) // Evil Boss [ Eater Of Worlds or Brain Of Cthulhu ]
            {
                StarterItems.Set(PluginSettings.GetBosses.EvilBoss_BOC_EOW);
                return;
            }
            if (NPC.downedBoss1)
            {
                StarterItems.Set(PluginSettings.GetBosses.EyeOfCthulhu);
                return;
            }
            if (NPC.downedSlimeKing)
            {
                StarterItems.Set(PluginSettings.GetBosses.KingSlime);
                return;
            }
        }
    }
}
