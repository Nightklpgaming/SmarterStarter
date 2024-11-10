﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.Hooks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace SmarterStarter
{
    [ApiVersion(2, 1)]
    public class Plugin : TerrariaPlugin
    {
        public override string Name => "SmarterStarter";
        public override Version Version => new Version(1, 1);
        public override string Author => "Sebastian Alsina ( ported and updated By Nightklp )";
        public override string Description => "SmarterStarter changes SSC's starer items based on boss progression.";

        public Plugin(Main game) : base(game)
        {

        }

        public override void Initialize()
        {
            PluginSettings.LoadSettings();
            ServerApi.Hooks.ServerJoin.Register(this, OnServerJoin);
            GeneralHooks.ReloadEvent += OnReload;
        }

        void OnServerJoin(JoinEventArgs args)
        {
            CheckBosses.Check();
        }

        private void OnReload(ReloadEventArgs args)
        {
            PluginSettings.LoadSettings();
            CheckBosses.Check();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose
                ServerApi.Hooks.ServerJoin.Deregister(this, OnServerJoin);
                GeneralHooks.ReloadEvent -= OnReload;
            }
            base.Dispose(disposing);
        }

    }
}
