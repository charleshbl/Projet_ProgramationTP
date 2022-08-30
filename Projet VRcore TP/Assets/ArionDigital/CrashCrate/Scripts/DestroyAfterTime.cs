namespace ArionDigital
{
    using UnityEngine;
    //DESCLARATION DES cLasses : DESTRUCTION DE LA CAISSE 
    public class DestroyAfterTime : MonoBehaviour
    {
        private void Start()
        {
            Invoke("DestroySelf", 3.0f); // PARTICULES DE LA CAISSE ET LEURS DISTANCES PAR RAPPORT A LA DESTUCTION 
        }

        void DestroySelf()
        {
            Destroy(gameObject); // DESGRUCTION DE LA CAISSE 
        }
    }
}