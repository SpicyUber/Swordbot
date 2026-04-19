using RoR2;
using UnityEngine;

namespace Swordbot.Survivors.Swordbot
{
    public static class SwordbotBuffs
    {
        // armor buff gained during roll
        public static BuffDef armorBuff, staticDebuff;
        public static void Init(AssetBundle assetBundle)
        {
            armorBuff = Modules.Content.CreateAndAddBuff("HenryArmorBuff",
                LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite,
                Color.white,
                false,
                false);
            staticDebuff = Modules.Content.CreateAndAddBuff("StaticDebuff",assetBundle.LoadAsset<Sprite>("Effect"), Color.yellow, false, true);
            
        }
    }
}
