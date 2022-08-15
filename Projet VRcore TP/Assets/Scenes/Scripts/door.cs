using System.Collections;
using System.Collections.Generic;
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
       _rbporte.constraints.Equals(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_porteName))
        {
            
            _rbporte.constraints.Equals(false);
     
          // animator.SetBool("IsOpen", true);
            //animator.Play("Anim_Door");
        }
    }
    


}
