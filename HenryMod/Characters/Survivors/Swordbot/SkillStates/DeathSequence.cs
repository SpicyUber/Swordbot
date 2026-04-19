using EntityStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordbot.Survivors.Swordbot.SkillStates
{
    public class DeathSequence : BaseState
    {
        public override void OnEnter()
        {
            PlayAnimation("Body", "Death");
            base.OnEnter();
        }
    }
}
