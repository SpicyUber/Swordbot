using RoR2;
using SwordbotMod.Characters.Survivors.Swordbot.Components;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

namespace Swordbot.Survivors.Swordbot.Components
{
    //static as in electricity but it also contains a static list :)
   
    public class SwordbotStaticComponent : MonoBehaviour
    {
        public static List<StaticMark> staticMarks;
        private static float _t=0;
        private void Awake()
        {
           staticMarks = new List<StaticMark>();
        }

        public static void Mark(Transform transform) { if (!NetworkServer.active) return;
            StaticMark existingMark = staticMarks.FirstOrDefault((StaticMark m) => {
                if (m == null || m.target == null) return false;
                int mInt1 =m.target.GetComponent<HurtBox>().healthComponent.GetInstanceID();
                if (transform.GetComponent<HurtBox>() == null) return false;
                int mInt2 = transform.GetComponent<HurtBox>().healthComponent.GetInstanceID();
                return mInt2 == mInt1; });
            if (existingMark!=null) { existingMark.timeToLive=SwordbotStaticValues.staticDuration; return; }
            GameObject go = new GameObject("SwordbotStaticMark" + staticMarks.Count, typeof(StaticMark), typeof(NetworkIdentity));
            StaticMark m1 = go.GetComponent<StaticMark>();
            m1.target = transform;
            m1.timeToLive = SwordbotStaticValues.staticDuration;
            NetworkServer.Spawn(go);
            staticMarks.Add(m1 ); }

        private void Update()
        {

            _t += Time.deltaTime;
            if( _t >= 1f ) {_t= 0;
                for (int i =staticMarks.Count-1;i>=0;i--) { StaticMark mark = staticMarks[i]; mark.timeToLive--; if(mark.TryDestroy())staticMarks.Remove(mark); }
            }
        }

       public static void Consume(GameObject gameObject, TeamIndex team, float damage)
        {
            for (int i = staticMarks.Count - 1; i >= 0; i--)
            {
             StaticMark mark = staticMarks[i]; mark.timeToLive--; mark.Consume(gameObject,team, damage); staticMarks.Remove(mark);

               

            }
        }



         
    }
}