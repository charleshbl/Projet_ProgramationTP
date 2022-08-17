using UnityEngine;

public class Door : MonoBehaviour
{//Déclaration des variables de la porte , le pivot , la serrure qui est une box de collision qui réagit avec la clé dans le jeu 
    //Déclaration des variables de l'animator : Component d'animation.
    public GameObject _porte;
    public GameObject _pivot;
    public Collider _serure;
    public string _porteName;
    Animator animator;
    Space _spacepivot;
    Rigidbody _rbporte;

    // Assigner de la physique et de l'animation a la porte et geler la rotation dans deux axes (X , Z )
    void Start()
    {

        _rbporte = _porte.GetComponent<Rigidbody>();
        animator = _porte.GetComponent<Animator>();
        _spacepivot = _pivot.GetComponent<Space>();
        // animator.Play("doorclose");
        _rbporte.freezeRotation = true;
        _rbporte.isKinematic = true;


    }

    // Update is called once per frame
    void Update()
    {

    }
    //Avoir la cinématique sur la porte , et qu'elle soit  influencé par la physique. 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_porteName))
        {
            _rbporte.isKinematic = false;
            _rbporte.constraints.Equals(false);
            _rbporte.freezeRotation = false;


            
        }
    }



}
