using UnityEngine;

public class Sound_SCRIPT : MonoBehaviour
{//déclaration des variables de la physique et la source audio dédié au son de la monnaie 
    public Rigidbody boxCollider;
    public AudioSource CashAudioClip;
    //des qu'une monnaie heurte une collision, le son joue.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CashAudioClip.Play();
        }
    }

    //Le joueur il touche la monnaie, le son joue. 

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            CashAudioClip.Play();
        }
    }
}
