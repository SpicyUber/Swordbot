using RoR2;
using UnityEngine;
using Swordbot.Modules;
using System;
using RoR2.Projectile;

namespace Swordbot.Survivors.Swordbot
{
    public static class SwordbotAssets
    {
        // particle effects
        public static GameObject swordSwingEffect;
        public static GameObject swordHitImpactEffect;
        public static GameObject staticEffect, explosionEffect;

        public static GameObject shockwaveExplosionEffect;

        // networked hit sounds
        public static NetworkSoundEventDef[] swordHitSoundEvents;

        //networked swing sounds
        public static NetworkSoundEventDef[] swordSwingSoundEvents;

        //networked special swing sound
        public static NetworkSoundEventDef specialSwingSoundEvent;

        //networked special hit sound
        public static NetworkSoundEventDef specialHitSoundEvent;
        //networked jump sound
        public static NetworkSoundEventDef JumpSoundEvent;
        //networked dash sound
        public static NetworkSoundEventDef DashSoundEvent;

        //projectiles
        public static GameObject bombProjectilePrefab;

        private static AssetBundle _assetBundle;

        public static void Init(AssetBundle assetBundle)
        {

            _assetBundle = assetBundle;

           // swordHitSoundEvent = Content.CreateAndAddNetworkSoundEventDef("HenrySwordHit");
           CreateSounds();
            CreateEffects();

            CreateProjectiles();
        }

        #region effects
        private static void CreateEffects()
        {
            CreateShockwaveExplosionEffect();
            staticEffect = _assetBundle.LoadEffect("Static");
            explosionEffect = _assetBundle.LoadEffect("Explosion");
            swordSwingEffect = _assetBundle.LoadEffect("HenrySwordSwingEffect", true);
            swordHitImpactEffect = _assetBundle.LoadEffect("ImpactHenrySlash");
        }

        private static void CreateSounds()
        {
            swordHitSoundEvents = new NetworkSoundEventDef[]
            {
                Content.CreateAndAddNetworkSoundEventDef("Play_attack0"),
                Content.CreateAndAddNetworkSoundEventDef("Play_attack1"),
                Content.CreateAndAddNetworkSoundEventDef("Play_attack2")
            };

            swordSwingSoundEvents = new NetworkSoundEventDef[]
           {
                Content.CreateAndAddNetworkSoundEventDef("Play_swing0"),
                Content.CreateAndAddNetworkSoundEventDef("Play_swing1"),
                Content.CreateAndAddNetworkSoundEventDef("Play_swing2")
           };

            specialHitSoundEvent = Content.CreateAndAddNetworkSoundEventDef("Play_specialhit");
            specialSwingSoundEvent = Content.CreateAndAddNetworkSoundEventDef("Play_special");
            JumpSoundEvent = Content.CreateAndAddNetworkSoundEventDef("Play_jump0");
            DashSoundEvent = Content.CreateAndAddNetworkSoundEventDef("Play_dash");
        }

        private static void CreateShockwaveExplosionEffect()
        {
            shockwaveExplosionEffect = _assetBundle.LoadEffect("Shockwave");

            if (!shockwaveExplosionEffect)
                return;

            ShakeEmitter shakeEmitter = shockwaveExplosionEffect.AddComponent<ShakeEmitter>();
            shakeEmitter.amplitudeTimeDecay = true;
            shakeEmitter.duration = 0.25f;
            shakeEmitter.radius = 200f;
            shakeEmitter.scaleShakeRadiusWithLocalScale = false;

            shakeEmitter.wave = new Wave
            {
                amplitude = 1f,
                frequency = 40f,
                cycleOffset = 0f
            };

        }
        #endregion effects

        #region projectiles
        private static void CreateProjectiles()
        {
            CreateBombProjectile();
            Content.AddProjectilePrefab(bombProjectilePrefab);
        }

        private static void CreateBombProjectile()
        {
            //highly recommend setting up projectiles in editor, but this is a quick and dirty way to prototype if you want
            bombProjectilePrefab = Asset.CloneProjectilePrefab("CommandoGrenadeProjectile", "HenryBombProjectile");

            //remove their ProjectileImpactExplosion component and start from default values
            UnityEngine.Object.Destroy(bombProjectilePrefab.GetComponent<ProjectileImpactExplosion>());
            ProjectileImpactExplosion bombImpactExplosion = bombProjectilePrefab.AddComponent<ProjectileImpactExplosion>();
            
            bombImpactExplosion.blastRadius = 16f;
            bombImpactExplosion.blastDamageCoefficient = 1f;
            bombImpactExplosion.falloffModel = BlastAttack.FalloffModel.None;
            bombImpactExplosion.destroyOnEnemy = true;
            bombImpactExplosion.lifetime = 12f;
            bombImpactExplosion.impactEffect = shockwaveExplosionEffect;
            //bombImpactExplosion.lifetimeExpiredSound = Content.CreateAndAddNetworkSoundEventDef("HenryBombExplosion");
            bombImpactExplosion.timerAfterImpact = true;
            bombImpactExplosion.lifetimeAfterImpact = 0.1f;

            ProjectileController bombController = bombProjectilePrefab.GetComponent<ProjectileController>();

            if (_assetBundle.LoadAsset<GameObject>("HenryBombGhost") != null)
                bombController.ghostPrefab = _assetBundle.CreateProjectileGhostPrefab("HenryBombGhost");
            
            bombController.startSound = "";
        }
        #endregion projectiles
    }
}
