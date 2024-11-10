using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Steamworks;
using System;
using System.IO;
using TShockAPI;

namespace SmarterStarter
{
    public class StarterItems
    {
        public class Item
        {
            public int netID { get; set; }
            public int prefix { get; set; }
            public int stack { get; set; }

            public Item(int netID, int prefix, int stack)
            {
                this.netID = netID;
                this.prefix = prefix;
                this.stack = stack;
            }
        }

        public class PlayerSettings
        {
            public int? health { get; set; }
            public int? mana { get; set; }
            public StarterItems.Item[]? items { get; set; }

            public PlayerSettings()
            {
                health = 100;
                mana = 20;
                StarterItems.Item[]  setitems = {
                    new StarterItems.Item(Terraria.ID.ItemID.CopperShortsword, 0, 1),
                    new StarterItems.Item(Terraria.ID.ItemID.CopperPickaxe, 0, 1),
                    new StarterItems.Item(Terraria.ID.ItemID.CopperAxe, 0, 1)
                };
                items = setitems;
            }

            public void FixNull()
            {
                if (health == null) health = 100;
                if (mana == null) mana = 20;
                StarterItems.Item[] setitems = {
                    new StarterItems.Item(Terraria.ID.ItemID.CopperShortsword, 0, 1),
                    new StarterItems.Item(Terraria.ID.ItemID.CopperPickaxe, 0, 1),
                    new StarterItems.Item(Terraria.ID.ItemID.CopperAxe, 0, 1)
                };
                if (items == null) items = setitems;
            }
        }

        public static void Set(PlayerSettings settings)
        {
            string path = File.ReadAllText("tshock/sscconfig.json");
            dynamic jsonObject = JsonConvert.DeserializeObject(path);
            jsonObject["StartingHealth"] = (int)settings.health;
            jsonObject["StartingMana"] = (int)settings.mana;
            jsonObject["StartingInventory"] = JToken.FromObject((StarterItems.Item[])settings.items);
            dynamic jsonObjectNew = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText("tshock/sscconfig.json", jsonObjectNew);

            TShock.Utils.Reload();

            Console.WriteLine("SSC items have been updated.");
        }
    }
}
