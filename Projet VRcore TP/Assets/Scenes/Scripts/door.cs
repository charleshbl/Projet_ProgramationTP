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
    // Start is called before the first frame update
    void Start()
    {
       
        animator = _porte.GetComponent<Animator>();
        _spacepivot = _pivot.GetComponent<Space>();
       // animator.Play("doorclose");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_porteName))
        {
           // _porte.GetComponent<Rigidbody>().mass = 1;
          // _porte.transform.Rotate(0, 90, 0, relativeTo: _spacepivot);
           animator.SetBool("IsOpen", true);
            //animator.Play("Anim_Door");
        }
    }
    


}
