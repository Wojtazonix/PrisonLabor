﻿using PrisonLabor.HarmonyPatches;
using PrisonLabor.Tweaks;
using System;
using Verse;

namespace PrisonLabor
{
    [StaticConstructorOnStartup]
    internal class Initialization
    {
        static Initialization()
        {
            try
            {
                PrisonLaborPrefs.Init();
                HPatcher.Init();
                ClassInjector.Init();
                SettingsMenu.Init();
                VersionUtility.CheckVersion();
                Designator_AreaLabor.Initialization();
                Behaviour_MotivationIcon.Initialization();
                CompatibilityPatches.Initialization.Run();
                HediffManager.Init();

                Log.Message($"Enabled Prison Labor v{VersionUtility.versionString}");
            }
            catch(Exception e)
            {
                Log.Error($"Prison Labor v{VersionUtility.versionString} caught error during start up:\n{e.Message}");
            }

        }
    }
}