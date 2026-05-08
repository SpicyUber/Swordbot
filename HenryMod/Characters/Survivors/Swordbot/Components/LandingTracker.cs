
using RoR2;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

namespace SwordbotMod.Characters.Survivors.Swordbot.Components
{
    public class LandingTracker : MonoBehaviour
    {
        public bool Grounded = false;
        public CharacterMotor Motor = null;

        void Update() 
        {
            bool previousGrounded = Grounded;

            if(Motor == null) return;

            Grounded = Motor.isGrounded;

            Vector2 moveDir = new Vector2(Motor.moveDirection.x, Motor.moveDirection.z);

            if(!previousGrounded && Grounded != previousGrounded && moveDir.magnitude<=0.0001f)
                Util.PlaySound("Play_land",gameObject);
        }
    }
}
