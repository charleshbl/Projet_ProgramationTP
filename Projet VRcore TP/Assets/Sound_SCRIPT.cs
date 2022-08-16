using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_SCRIPT : MonoBehaviour
{
    public Rigidbody boxCollider;
    public AudioSource CashAudioClip;
    private void OnCollisionEnter(Collision collision)
    {
        CashAudioClip.Play();

    }
    

    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CashAudioClip.Play();
    }
}
