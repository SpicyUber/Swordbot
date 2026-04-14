using BepInEx;
using R2API.Utils;
using RoR2;
using ShaderSwapper;
using Swordbot.Survivors.Swordbot;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
 

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

//rename this namespace
namespace Swordbot
{
    //[BepInDependency("com.rune580.riskofoptions", BepInDependency.DependencyFlags.SoftDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    public class SwordbotPlugin : BaseUnityPlugin
    {
        // if you do not change this, you are giving permission to deprecate the mod-
        //  please change the names to your own stuff, thanks
        //   this shouldn't even have to be said
        public const string MODUID = "com.spicyuber.Swordbot";
        public const string MODNAME = "Swordbot";
        public const string MODVERSION = "1.0.0";

        // a prefix for name tokens to prevent conflicts- please capitalize all name tokens for convention
        public const string DEVELOPER_PREFIX = "SPICYUBER";

        public static SwordbotPlugin instance;

        void Awake()
        {
            instance = this;

            //easy to use logger
            Log.Init(Logger);
            
            // used when you want to properly set up language folders
            Modules.Language.Init();

            // character initialization
            SwordbotSurvivor ss = new SwordbotSurvivor();
          
            ss.Initialize();


            base.StartCoroutine(ss.assetBundle.UpgradeStubbedShadersAsync());

            // make a content pack and add it. this has to be last
            new Modules.ContentPacks().Initialize();
        }
    }
}
