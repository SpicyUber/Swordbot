using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoR2;


public class PlaySwordbotSoundOnEnable : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;

    private void OnEnable() => AudioSource.PlayClipAtPoint(_clip, transform.position);
}
