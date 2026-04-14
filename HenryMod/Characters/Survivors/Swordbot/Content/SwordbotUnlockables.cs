using Swordbot.Survivors.Swordbot.Achievements;
using RoR2;
using UnityEngine;

namespace Swordbot.Survivors.Swordbot
{
    public static class SwordbotUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                SwordbotMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(SwordbotMasteryAchievement.identifier),
                SwordbotSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
