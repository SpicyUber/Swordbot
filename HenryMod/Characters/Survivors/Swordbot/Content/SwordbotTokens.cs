using System;
using Swordbot.Modules;
using Swordbot.Survivors.Swordbot.Achievements;

namespace Swordbot.Survivors.Swordbot
{
    public static class SwordbotTokens
    {
        public static void Init()
        {
            AddHenryTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Henry.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddHenryTokens()
        {
            string prefix = SwordbotSurvivor.HENRY_PREFIX;

            string desc = /*"Henry is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine
             + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine
             + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine
             + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;*/
"Swordbot is a robot who makes use of his clunky sword and malfunctioning hardware to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Sword contains a 3 part combo, where the third hit does extra knockback." + Environment.NewLine + Environment.NewLine
             + "< ! > Attacks apply static. Static can be detonated with the second ability." + Environment.NewLine + Environment.NewLine
             + "< ! > Dash has a lingering barrier buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine
             + "< ! > Special ability behaves differently depending on if you're airborne." + Environment.NewLine + Environment.NewLine;


            string outro = "..and so he left, looking for another sandbag.";
            string outroFailure = "..and so he vanished, his components adrift.";

            Language.Add(prefix + "NAME", "Henry");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "Hug Immune");
            Language.Add(prefix + "LORE", "Unknown.");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Malfunctioning Components");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", $"Swordbot's attacks apply static to the enemy for the duration of {SwordbotStaticValues.staticDuration}s");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SLASH_NAME", "Big Sword");
            Language.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Tokens.agilePrefix + $"Three part combo where each strike does <style=cIsDamage>{100f * SwordbotStaticValues.swordDamageCoefficient}% damage. The third strike does extra knockback</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_GUN_NAME", "Thunderclap");
            Language.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Tokens.agilePrefix + $"Consumes all stacks, creating an electric explosion in their place for <style=cIsDamage>{100f * SwordbotStaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_ROLL_NAME", "Hardening Dash");
            Language.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Dash a short distance, gaining barrier. <style=cIsUtility>Barrier ammount scales with HP</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_BOMB_NAME", "V-Slice");
            Language.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Attack while moving vertically, dragging enemies along for the ride. Changes direction depending on if Swordbot is grounded.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(SwordbotMasteryAchievement.identifier), "Swordbot: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(SwordbotMasteryAchievement.identifier), "As Swordbot, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
