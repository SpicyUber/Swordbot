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
        string airbornePrefix => (characterMotor.isGrounded) ? "" : "Air";
         

       
        public override void OnEnter()
        {
            if (characterMotor.isGrounded) PreviousStateTracker.PreviousState = null;
            if (characterMotor && !characterMotor.isGrounded) swingIndex = swingIndex % 2;
            bool isAir = !characterMotor.isGrounded;
            Debug.Log("FART2"+isAir);
            hitboxGroupName = "SwordGroup";
            hitEnemies = new List<HealthComponent>();
            damageType = DamageTypeCombo.GenericPrimary;
            damageCoefficient = SwordbotStaticValues.swordDamageCoefficient;
            procCoefficient = 1f;
            if (isAir)
            {
                pushForce = 0f;
                
                bonusForce =
                    Vector3.zero;
                hitStopDuration = 0.1f;
                attackRecoil = 0.5f;
                hitHopVelocity = 12f;
                physFlags = PhysForceFlags.massIsOne;
                
            }
            else
            {
                pushForce = 50f;
                float upForce = 5f;
                hitStopDuration = 0.1f;
                attackRecoil = 0.5f;
                hitHopVelocity = 0f;

              
                physFlags = PhysForceFlags.resetVelocity| PhysForceFlags.ignoreGroundStick;

                bonusForce = (Vector3.up*(1.5f-0.5f*((swingIndex)/2)) +base.characterBody.inputBank.aimDirection).normalized * (4000f * ((swingIndex == 2) ? 1 : 0.3f));
                Debug.Log(base.characterBody.inputBank.aimDirection + "BF");
                
            }
            slashingStopwatch = 0;
            Debug.Log("si:" + swingIndex);
            baseDuration = 1.734f;
            
           
            
            //0-1 multiplier of baseduration, used to time when the hitbox is out (usually based on the run time of the animation)
            //for example, if attackStartPercentTime is 0.5, the attack will start hitting halfway through the ability. if baseduration is 3 seconds, the attack will start happening at 1.5 seconds
            attackStartPercentTime = 0.12f;
            attackEndPercentTime = 0.28f;

            //this is the point at which the attack can be interrupted by itself, continuing a combo
            earlyExitPercentTime = 0.48f;
            
            

           

             
            

            swingSoundString = $"Play_swing{swingIndex}";//"HenrySwordSwing"
            hitSoundString = $"Play_attack{swingIndex}";
            muzzleString = swingIndex % 2 == 0 ? "SwingLeft" : "SwingRight";
            playbackRateParam = "Slash.playbackRate";
            swingEffectPrefab = SwordbotAssets.swordSwingEffect;
            hitEffectPrefab = SwordbotAssets.swordHitImpactEffect;
             
            impactSound = SwordbotAssets.swordHitSoundEvents[swingIndex].index;

            base.OnEnter();
            duration = baseDuration / Mathf.Log(attackSpeedStat + 2);
            StartAimMode(duration*(attackEndPercentTime), true);
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
            if (characterMotor && !characterMotor.isGrounded) swingIndex = swingIndex % 2;
        }
    
       

        protected override void PlayAttackAnimation()
        {
           PlayAnimation("Gesture, Override", airbornePrefix+"Slash" + (1 + swingIndex), playbackRateParam, duration, 0);
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