using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject _porte;
    public GameObject _pivot;
    public Collider _serure;
    public string _porteName;
    // Start is called before the first frame update
    void Start()
    {
        _porte = GetComponent<GameObject>();
        _pivot = GetComponent<GameObject>();
        _serure = GetComponent<Collider>();
   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (_porteName == other.tag)
        {
            // _porte.GetComponent<Rigidbody>().mass = 1;
            _porte.transform.Rotate(_pivot.transform.position,90);       

        }
    }

   

}

