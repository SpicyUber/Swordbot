using EntityStates;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Swordbot.Survivors.Swordbot.SkillStates
{
    public class DeathSequence : BaseState
    {
        private float stopwatch = 0;
        private bool didNotExplode = true;
        private readonly float deathDuration = 3.0f;

        public override void OnEnter()
        {
            stopwatch = 0;
            didNotExplode = true;
            PlayAnimation("Body", "Death");
            Util.PlaySound("Play_death_start", gameObject);
            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            stopwatch += Time.fixedDeltaTime;
            if(stopwatch > deathDuration && didNotExplode)
            {
                Util.PlaySound("Play_death_end", gameObject);
                didNotExplode = false;
            }

            base.FixedUpdate();

        }
    }
}
