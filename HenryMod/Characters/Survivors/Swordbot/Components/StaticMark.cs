using RoR2;
using Swordbot.Survivors.Swordbot;
using Swordbot.Survivors.Swordbot.Components;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Swordbot.Modules; 

using UnityEngine.Networking;
 
using UnityEngine.PlayerLoop;

namespace SwordbotMod.Characters.Survivors.Swordbot.Components
{
    public class StaticMark : MonoBehaviour
    {
        public Transform target;
        public float timeToLive = SwordbotStaticValues.staticDuration;
        public ParticleSystem staticParticles;

        internal bool TryDestroy()
        {
            bool condition = timeToLive <= 0 && NetworkServer.active;
            if (condition) { /*NetworkServer.UnSpawn(staticEffect);*/ NetworkServer.DestroyObject(this.gameObject); } 
            return condition;
        }

        internal void Consume(GameObject gameObject,TeamIndex team, float damage)
        {
            
            Explosion(gameObject,team,damage);
            timeToLive = 0;
            TryDestroy();
           
        }

        private void Explosion(GameObject gameObject, TeamIndex team,float damage) {
            Debug.Log($"BOOM! at {transform.position}");
           GameObject.Instantiate(SwordbotAssets.explosionEffect).transform.position=transform.position;

            DamageInfo damageInfo = new DamageInfo() { attacker= gameObject, inflictor= gameObject, crit=false,damageColorIndex=DamageColorIndex.Electrocution,damage = damage,force=Vector3.zero,damageType=DamageType.Stun1s, procCoefficient=1 };
            HashSet<int> ignoredHealthComponents = new HashSet<int>();
            //ignoredHealthComponents.Add(gameObject)
            foreach (Collider c in Physics.OverlapSphere(target.position, SwordbotStaticValues.staticRadius))
            {
                HurtBox hb = c.GetComponent<HurtBox>();
                if (hb == null || ignoredHealthComponents.Contains(hb.healthComponent.GetInstanceID()) || hb.healthComponent.body.teamComponent.teamIndex==team) continue; 
                hb.healthComponent.TakeDamage(damageInfo);
                ignoredHealthComponents.Add(hb.healthComponent.GetInstanceID());
                Debug.Log($"BOOM!{ignoredHealthComponents.Count},{hb.healthComponent.GetInstanceID()},{hb.healthComponent.name}");
                if(target!=null && target.GetComponent<HurtBox>()!=null && target.GetComponent<HurtBox>().healthComponent.GetInstanceID()!=hb.healthComponent.GetInstanceID())SwordbotStaticComponent.Mark(hb.transform);
                Util.PlaySound("Play_static", hb.gameObject);
            }

            
        }

        public void Start()
        {
          staticParticles = GameObject.Instantiate( SwordbotAssets.staticEffect,this.transform).GetComponent<ParticleSystem>();
         
        }

      public void Update()
        {
            if (target != null) {


                /*Component[] components = target.parent.GetComponentsInParent(typeof(Component));
                foreach (Component component in components)
                {
                    Debug.Log("parent parent:"+component.ToString());
                }*/
                CharacterModel cm = target.parent.GetComponentInParent<RoR2.CharacterModel>();
                if (cm==null|| !cm.enabled) staticParticles.Stop();            
                transform.position = target.position;
            
            }
        }
    }
}
