using EntityStates;
using RoR2;
using Swordbot.Modules.BaseStates;
using Swordbot.Survivors.Swordbot;
using SwordbotMod.Characters.Survivors.Swordbot.Components;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;


namespace Swordbot.Survivors.Swordbot.SkillStates
{
    public class UpSlash : BaseMeleeAttack
    {

        List<HealthComponent> hitEnemies;
        float upSlashMidAttackRange;
        float applyMidAttackInterval;
        float applyMidAttackTimer;
        Vector3 midAttackForce;
        float midAttackDuration;
        private bool dashUpFlag=true;
        private int upDirectionNumber;
        private CharacterBody.BodyFlags bodyFlags;
        public override void OnEnter()
        {  
            bodyFlags = characterBody.bodyFlags;
            upDirectionNumber = (characterMotor.isGrounded) ? 1 : -1;
            hitboxGroupName = "SwordGroup";
            hitEnemies = new List<HealthComponent>();
            damageType = DamageTypeCombo.GenericPrimary;
            damageCoefficient = SwordbotStaticValues.swordDamageCoefficient/12f;
            procCoefficient = 1f;
            pushForce = 2f;
            duration = 1f;
             Vector3 dir = characterBody.inputBank.aimDirection;
                dir.y = 0; dir.Normalize();
            bonusForce =  dir * 6f+ Vector3.up *40f* upDirectionNumber;
            Debug.Log("si:" + swingIndex);
            baseDuration = 2f;
            //0-1 multiplier of baseduration, used to time when the hitbox is out (usually based on the run time of the animation)
            //for example, if attackStartPercentTime is 0.5, the attack will start hitting halfway through the ability. if baseduration is 3 seconds, the attack will start happening at 1.5 seconds
            attackStartPercentTime = 0f;
            attackEndPercentTime = 0.4f;
            
            //this is the point at which the attack can be interrupted by itself, continuing a combo
            earlyExitPercentTime = 0.2f;

            hitStopDuration = 0f;
            attackRecoil = 0f;
            hitHopVelocity = 0f;

            swingSoundString = $"Play_special";//"HenrySwordSwing"
            hitSoundString = $"Play_specialHit";

            midAttackDuration = 0.38f;
            applyMidAttackInterval  = 0.2f;
            applyMidAttackTimer = applyMidAttackInterval;
           
            upSlashMidAttackRange = 25f;
            midAttackForce = bonusForce;

        
            base.OnEnter();

            StartAimMode(duration, true);
        }
     
        public override InterruptPriority GetMinimumInterruptPriority()
        {
            if (stopwatch >= duration * earlyExitPercentTime)
            {
                return InterruptPriority.Any;
            }
            return InterruptPriority.Pain;
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
             
            if (stopwatch>0.1f && isAuthority && dashUpFlag)
            {
                PunchAllEnemiesUp();
                characterBody.bodyFlags |= CharacterBody.BodyFlags.IgnoreFallDamage;

                float upwardForce = 40f;
                dashUpFlag = false;
                characterMotor.velocity = Vector3.up * upwardForce* upDirectionNumber;
            }

            if (isAuthority && stopwatch < duration*midAttackDuration) {
               if( upDirectionNumber==1 )characterMotor.Motor.ForceUnground();
                applyMidAttackTimer -= Time.fixedDeltaTime;
                if(applyMidAttackTimer <= 0f) {
                     
                    PunchAllEnemiesUp();
                    applyMidAttackTimer = applyMidAttackInterval;
                }


            }


            if (isAuthority && (fixedAge >= duration || (upDirectionNumber==-1 && characterMotor.isGrounded)))
            {
              if(upDirectionNumber==-1)  Shockwave();
               
                outer.SetNextStateToMain();
                return;
            }
        }
        protected override void PlayAttackAnimation()
        {
            PlayAnimation("Gesture, Override", "Slash" + ((upDirectionNumber==1)? "Up":"Down"), playbackRateParam, duration, 0);
        }
        private void Shockwave()
        {
            foreach (HealthComponent enemy in hitEnemies)
            {
                if (enemy == null || characterBody == null || Vector3.Distance(enemy.transform.position, characterBody.transform.position) > upSlashMidAttackRange) continue;
                Vector3 dir = characterBody.inputBank.aimDirection;
                dir.y = 0; dir.Normalize();
                midAttackForce = dir * 350f + Vector3.up * 2000f ;
                Debug.Log("ATTEMPTING Shockwave ENEMY!" + enemy.name);

                enemy.TakeDamage(new DamageInfo() {attacker=gameObject,  inflictor = gameObject, procCoefficient = 1, damageType = damageType, damage = attack.damage, position = characterBody.transform.position, force = midAttackForce, physForceFlags = PhysForceFlags.ignoreGroundStick, canRejectForce = false });
                
                

            }
            Util.PlaySound("Play_landing", gameObject);
        }

        protected void PunchAllEnemiesUp()
        {
            for (int i=0;i< hitEnemies.Count;i++)
            {
                var enemy = hitEnemies[i];
                var characterToEnemyFlattened = (enemy.transform.position - characterBody.transform.position);
                characterToEnemyFlattened.y = 0;
                characterToEnemyFlattened.Normalize();
                var aimDirectionFlattened = characterBody.inputBank.aimDirection;
                aimDirectionFlattened.y = 0;
                aimDirectionFlattened.Normalize();
                if (Vector3.Dot((enemy.transform.position - characterBody.transform.position).normalized, characterBody.inputBank.aimDirection) < 0) { hitEnemies.RemoveAt(i); i--; continue; }
                if ( enemy == null || enemy.body.isBoss || enemy.body.isBoss || characterBody == null || Vector3.Distance(enemy.transform.position, characterBody.transform.position) > upSlashMidAttackRange) continue;
                Vector3 dir = characterBody.inputBank.aimDirection;
                dir.y = 0; dir.Normalize();
                midAttackForce = ((characterBody.transform.position - enemy.transform.position) + 2*dir) + Vector3.up * Mathf.Max(0,((midAttackDuration-stopwatch)/midAttackDuration))* 35f* upDirectionNumber* ((upDirectionNumber < 0) ? 3 : 1);
                
                Debug.Log("ATTEMPTING PUNCH UP ENEMY!" + enemy.name);
                 
                enemy.TakeDamage(new DamageInfo() {attacker=gameObject, inflictor = gameObject, procCoefficient = 1, damageType = damageType, damage = attack.damage, position = characterBody.transform.position, force = midAttackForce, physForceFlags = PhysForceFlags.massIsOne, canRejectForce = false });
                Util.PlaySound(hitSoundString, enemy.gameObject);


            }



        }
        protected override void OnHitEnemyAuthority()
        {
             
            
            base.OnHitEnemyAuthority();
        }

        protected override void ModifyHitHurtBoxes(List<HurtBox> hurtBoxes)
        {
            foreach (HurtBox box in hurtBoxes) { TryAddEnemyHC(box.healthComponent); }
            base.ModifyHitHurtBoxes(hurtBoxes);
        }

        private void TryAddEnemyHC(HealthComponent healthComponent)
        {
            if (healthComponent == null) { Debug.Log("cant add null"); return; }
            if (hitEnemies.Exists((HealthComponent hc) => { return hc.GetInstanceID() == healthComponent.GetInstanceID(); })) return;
            hitEnemies.Add(healthComponent);
            Debug.Log("ADDED" + healthComponent);
        }
        public override void OnExit()
        {

            characterBody.SetAimTimer(0);

            characterBody.bodyFlags = bodyFlags;
            PreviousStateTracker.PreviousState = this.GetType();
            base.OnExit();
        }
    }
}
