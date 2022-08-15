using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject _porte;
    public GameObject _pivot;
    public Collider _serure;
    public string _porteName;
    Space _spacepivot;
    // Start is called before the first frame update
    void Start()
    {
        _porte = GetComponent<GameObject>();
        _pivot = GetComponent<GameObject>();
        _serure = GetComponent<Collider>();
      
       _spacepivot = _pivot.GetComponent<Space>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_porteName))
        {
            _porte.GetComponent<Rigidbody>().mass = 1;
            _porte.transform.Rotate(0,90,0,relativeTo:_spacepivot);

        }
    }
    


}

