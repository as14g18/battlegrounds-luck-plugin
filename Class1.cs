using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;
using Hearthstone_Deck_Tracker.Plugins;

namespace LuckyPlugin
{
    public class Class1
    {
        internal static void TurnStart(ActivePlayer player)
        {

        }

        internal static void GameStart()
        {

        }
    }

    public class Class1Plugin : IPlugin
    {

        public void OnLoad()
        {
            // Triggered upon startup and when the user ticks the plugin on
            GameEvents.OnGameStart.Add(Class1.GameStart);
            GameEvents.OnTurnStart.Add(Class1.TurnStart);
        }

        public void OnUnload()
        {
            // Triggered when the user unticks the plugin, however, HDT does not completely unload the plugin.
            // see https://git.io/vxEcH
        }

        public void OnButtonPress()
        {
            // Triggered when the user clicks your button in the plugin list
        }

        public void OnUpdate()
        {
            // called every ~100ms
        }

        public string Name => "Battlegrounds Luck Calculator";

        public string Description => "A plugin for Hearthstone Battlegrounds that determines how lucky or unlucky you were in a particular round.";

        public string ButtonText => "";

        public string Author => "Akhilesh Shastri";

        public Version Version => new Version(0, 0, 1);

        public MenuItem MenuItem => null;
    }
}
