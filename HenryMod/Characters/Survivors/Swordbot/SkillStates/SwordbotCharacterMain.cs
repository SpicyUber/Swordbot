using EntityStates;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwordbotMod.Characters.Survivors.Swordbot.SkillStates
{
    public class SwordbotCharacterMain : GenericCharacterMain
    {
        public override void ProcessJump()
        {
            Util.PlaySound("Play_jump", gameObject);
            base.ProcessJump();
            
        }
    }
}
