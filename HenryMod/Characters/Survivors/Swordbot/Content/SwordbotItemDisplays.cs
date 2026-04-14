using Swordbot.Modules;
using Swordbot.Modules.Characters;
using RoR2;
using System.Collections.Generic;
using UnityEngine;

/* for custom copy format in keb's helper
{childName},
                    {localPos}, 
                    {localAngles},
                    {localScale})
*/

namespace Swordbot.Survivors.Swordbot
{
    public class SwordbotItemDisplays : ItemDisplaysBase
    {
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AlienHead"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAlienHead"),
                    "hat",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorPlate"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorReductionOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarhammer"),
                    "cape",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedAndMoveSpeed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCoffee"),
                    "cape",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                    "cape",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AutoCastEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFossil"),
                    "cape",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bandolier"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBandolier"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrooch"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnOverHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAegis"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bear"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBear"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BearVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBearVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BeetleGland"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Behemoth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBehemoth"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTip"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitAndExplode"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTipVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BonusGoldPackOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTome"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAPRound"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BounceNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHook"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkulele"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightningVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkuleleVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Clover"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayClover"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CloverVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCloverVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CooldownOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkull"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserSight"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlasses"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlassesVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlassesVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Crowbar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCrowbar"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Dagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDagger"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathMark"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathMark"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElementalRingVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVoidRing"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EmpowerAlways"],
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHeadNeck"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHead"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EnergizedOnEquipmentUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarHorn"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBattery"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazineVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFuelCellVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExecuteLowHealthElite"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGuillotine"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeath"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeathVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWillowWispVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLife"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippo"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLifeVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippoVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FallBoots"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Feather"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFeather"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireballsOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireballsOnHit"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireRing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireRing"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Firework"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFirework"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FlatHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySteakCurved"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FocusConvergence"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FragileDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDelicateWatch"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FreeChest"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShippingRequestForm"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GhostOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMask"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBoneCrown"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHurt"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRollOfPennies"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfAttackSpeedHalfCooldowns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderNature"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfSpeedDoubleHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderStone"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HeadHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkullcrown"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealingPotion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHealingPotion"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScythe"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealWhileSafe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySnail"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Hoof"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHoof"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IceRing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIceRing"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Icicle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IgniteOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasoline"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ImmuneToDebuff"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRainCoatBelt"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreaseHealing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Incubator"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAncestralIncubator"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Infusion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInfusion"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["JumpBoost"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaxBird"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["KillEliteFrenzy"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Knurl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKnurl"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LaserTurbine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LightningStrikeOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayChargedPerforator"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarDagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarDagger"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPrimaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdEye"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSecondaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdClaw"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSpecialReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdHeart"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarTrinket"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeads"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarUtilityReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdFoot"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Medkit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMedkit"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MinorConstructOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDefenseNucleus"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Missile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MissileVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncherVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MonstersOnShrineUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoreMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoveSpeedOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGrappleHook"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Mushroom"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroom"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MushroomVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroomVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NearbyDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDiamond"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "head",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "head",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJellyGuts"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["OutOfCombatArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayOddlyShapedOpal"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ParentEgg"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayParentEgg"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Pearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPearl"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PermanentDebuffOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScorpion"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PersonalShield"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Phasing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStealthkit"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Plant"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInterstellarDeskPlant"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PrimarySkillShuriken"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShuriken"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomDamageZone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomEquipmentTrigger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBottledChaos"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomlyLunar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDomino"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RegeneratingScrap"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRegeneratingScrap"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RepeatHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCorpseflower"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SecondarySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Seed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySeed"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShieldOnly"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShinyPearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShockNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SiphonOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySiphonOnLowHealth"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBauble"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBaubleVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBuckler"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySoda"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintOutOfCombat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWhip"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintWisp"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrokenMask"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Squid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySquidTurret"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StickyBomb"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStickyBomb"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StrengthenBurn"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasTank"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StunChanceOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStunGrenade"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Syringe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Talisman"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTalisman"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Thorns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRazorwireLeft"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TitanGoldDuringTP"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldHeart"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tooth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothNecklaceDecal"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TPHealingNova"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlowFlower"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCache"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKey"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCacheVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKeyVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["UtilitySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VoidMegaCrabItem"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMegaCrabItem"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WarCryOnMultiKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPauldron"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WardOnLevel"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarbanner"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BFG"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBFG"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Blackhole"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravCube"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornGhost"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBlunderbuss"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunterConsumed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornUsed"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BurnNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPotion"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Cleanse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaterPack"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CommandMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileRack"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CrippleWard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEffigy"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritOnUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayNeuralImplant"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathProjectile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathProjectile"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DroneBackup"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRadio"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteEarthEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteMendingAntlers"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteFireEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteHauntedEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
                    "head",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteIceEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
                    "head",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLightningEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLunarEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteLunar,Eye"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElitePoisonEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteUrchinCrown"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteVoidEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAffixVoid"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireBallDash"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEgg"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Fruit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFruit"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GainArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElephantFigure"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Gateway"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVase"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldGat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldGat"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GummyClone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGummyClone"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IrradiatingLaser"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIrradiatingLaser"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Jetpack"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBugWings"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LifestealOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Lightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLightningArmRight"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPortalOnUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarPortalOnUse"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Meteor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMeteor"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Molotov"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMolotov"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MultiShopCard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayExecutiveCard"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["QuestVolatileBattery"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBatteryArray"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Recycle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRecycler"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Saw"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Scanner"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScanner"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TeamWarCry"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tonic"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTonic"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VendingMachine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVendingMachine"),
                    "body",
                    new Vector3(0.04f,0.04f,0.04f),
                    new Vector3(0, 0, 0),
                    new Vector3(0.0f,0.0f,0.0f)
                    )
                ));
        }
    }
}