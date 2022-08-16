using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject _porte;
    public GameObject _pivot;
    public Collider _serure;
    public string _porteName;
    Animator animator;
    Space _spacepivot;
    Rigidbody _rbporte;

    // Start is called before the first frame update
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_porteName))
        {
            _rbporte.isKinematic = false;
            _rbporte.constraints.Equals(false);
            _rbporte.freezeRotation = false;


            // animator.SetBool("IsOpen", true);
            //animator.Play("Anim_Door");
        }
    }



}
