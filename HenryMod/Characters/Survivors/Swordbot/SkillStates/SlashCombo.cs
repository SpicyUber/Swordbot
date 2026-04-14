using RoR2;
using Swordbot.Modules.BaseStates;
using SwordbotMod.Characters.Survivors.Swordbot.Components;
using System.Collections.Generic;
 
using UnityEngine;

namespace Swordbot.Survivors.Swordbot.SkillStates
{
    public class SlashCombo : BaseMeleeAttack
    {
        List<HealthComponent> hitEnemies;

        float swingMovementSpeed = 1f;
        float slashingStopwatch;
        float slashDashSpeed = 2f;
        public override void OnEnter()
        {
            if (characterMotor.isGrounded) PreviousStateTracker.PreviousState = null;

            

            hitboxGroupName = "SwordGroup";
            hitEnemies = new List<HealthComponent>();
            damageType = DamageTypeCombo.GenericPrimary;
            damageCoefficient = SwordbotStaticValues.swordDamageCoefficient;
            procCoefficient = 1f;
            pushForce =(swingIndex>0)?  25f:-50f;
            float upForce = 50f;
            if (!characterBody.characterMotor.isGrounded) { pushForce = 0f; upForce = 150f; }
            slashingStopwatch = 0;
           
            bonusForce =Vector3.up*upForce+ (base.characterBody.inputBank.aimDirection+ Vector3.up)*(4000f*((swingIndex==2)?1:0.001f));

            Debug.Log("si:"+swingIndex);
            

            baseDuration = 1.734f;
            duration = baseDuration / Mathf.Sqrt(attackSpeedStat);
            //0-1 multiplier of baseduration, used to time when the hitbox is out (usually based on the run time of the animation)
            //for example, if attackStartPercentTime is 0.5, the attack will start hitting halfway through the ability. if baseduration is 3 seconds, the attack will start happening at 1.5 seconds
            attackStartPercentTime = 0.12f;
            attackEndPercentTime = 0.28f;

            //this is the point at which the attack can be interrupted by itself, continuing a combo
            earlyExitPercentTime = 0.48f;
            
            physFlags = PhysForceFlags.ignoreGroundStick;

            hitStopDuration = 0.1f;
            attackRecoil = 0.5f;
            hitHopVelocity = 12f;

            

            swingSoundString = $"Play_swing{swingIndex}";//"HenrySwordSwing"
            hitSoundString = $"Play_attack{swingIndex}";
            muzzleString = swingIndex % 2 == 0 ? "SwingLeft" : "SwingRight";
            playbackRateParam = "Slash.playbackRate";
            swingEffectPrefab = SwordbotAssets.swordSwingEffect;
            hitEffectPrefab = SwordbotAssets.swordHitImpactEffect;
             
            impactSound = SwordbotAssets.swordHitSoundEvents[swingIndex].index;

            base.OnEnter();

            StartAimMode(duration*(earlyExitPercentTime), true);
        }

        public override void FixedUpdate()
        {
            slashingStopwatch += Time.fixedDeltaTime;
            if (/* PreviousStateTracker.PreviousState != null && PreviousStateTracker.PreviousState == typeof(  UpSlash)*/!characterMotor.isGrounded) { }
            else
            if (slashingStopwatch < attackStartPercentTime * duration) characterMotor.velocity = base.characterBody.inputBank.aimDirection * characterBody.baseMoveSpeed * slashDashSpeed;
            else
            if (slashingStopwatch < duration * (earlyExitPercentTime))
                characterMotor.velocity = Vector3.ClampMagnitude(characterMotor.velocity, swingMovementSpeed);
            



                base.FixedUpdate();
        }
    
       

        protected override void PlayAttackAnimation()
        {
           PlayAnimation("Gesture, Override", "Slash" + (1 + swingIndex), playbackRateParam, duration, 0);
        }

        protected override void PlaySwingEffect()
        {
            base.PlaySwingEffect();
        }
        protected override void ModifyHitHurtBoxes(List<HurtBox> hurtBoxes)
        {
               
            base.ModifyHitHurtBoxes(hurtBoxes);
        }
     

        protected override void OnHitEnemyAuthority()
        {
          /*  if (isAuthority)
            {
                GameObject go = attack.lastHitObject;
                if (go == null) return;
                Rigidbody rb = go.GetComponent<Rigidbody>();
                if (rb == null) return;
                Debug.Log("FOUND RB!");
                if (rb.velocity.y < 0) rb.velocity = new Vector3(rb.velocity.x,3f,rb.velocity.z);

            }*/
            base.OnHitEnemyAuthority();
        }
        
        public override void OnExit()
        {
            
            PreviousStateTracker.PreviousState = this.GetType();
            base.OnExit();
        }
    }
}