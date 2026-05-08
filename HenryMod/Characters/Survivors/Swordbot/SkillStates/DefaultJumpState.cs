using EntityStates;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Swordbot.Survivors.Swordbot.SkillStates
{
    public class DefaultJumpState: BaseState
    {   
        public override void FixedUpdate()
        {
            if(inputBank.jump.justPressed && characterMotor && characterMotor.isGrounded)
                Util.PlaySound("Play_jump", gameObject);

            base.FixedUpdate();

        }
    }
}
