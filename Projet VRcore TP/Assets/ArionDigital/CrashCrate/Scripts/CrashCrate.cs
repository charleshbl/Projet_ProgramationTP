namespace ArionDigital
{
    using UnityEngine;

    public class CrashCrate : MonoBehaviour
        //Venant d'une ASSET : déclaration de variables des caisses destructibles. 
    {
        [Header("Whole Create")]
        public MeshRenderer wholeCrate;
        public BoxCollider boxCollider;
        [Header("Fractured Create")]
        public GameObject fracturedCrate;
        [Header("Audio")]
        public AudioSource crashAudioClip;
        //DEstruction de la caisse en touchanbt une collision : jouer un son.
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Crate")) { return; }
            else
            {
                wholeCrate.enabled = false;
                boxCollider.enabled = false;
                fracturedCrate.SetActive(true); //Destruction 
                crashAudioClip.Play(); //SON
            }
        }

        [ContextMenu("Test")]
        public void Test()
        {
            wholeCrate.enabled = false;
            boxCollider.enabled = false;
            fracturedCrate.SetActive(true);
        }
    }
}