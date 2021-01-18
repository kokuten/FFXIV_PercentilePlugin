using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PercentilePlugin.Shared
{
   public class Instance
    {
        public Dictionary<string, Encounter> Encounters { get; set; } = new Dictionary<string, Encounter>();

        public string MapName { get; set; } = "";
        
        public static string InstanceFromBoss(string boss)
        {
            switch (boss)
            {
                case "The Unending Coil of Bahamut":
                    return "The Unending Coil of Bahamut (Ultimate)";
                    break;
                case "The Weapon's Refrain":
                    return "The Weapon's Refrain (Ultimate)";
                    break;
                case "The Epic of Alexander":
                    return "The Epic of Alexander (Ultimate)";
                    break;
                case "Shiva":
                    return "Akh Afah Amphitheatre (Unreal)";
                    break;
                case "Titan":
                    return "The Navel (Unreal)";
                    break;
                case "Cloud of Darkness":
                    return "Eden's Promise: Umbra (Savage)";
                    break;
                case "Shadowkeeper":
                    return "Eden's Promise: Litany (Savage)";
                    break;
                case "Fatebreaker":
                    return "Eden's Promise: Anamorphosis (Savage)";
                    break;
                case "Eden's Promise":
                case "Oracle of Darkness":
                    return "Eden's Promise: Eternity (Savage)";
                    break;
            }

            return "";
        }
    }
}
