using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject _porte;
    public Collider _serure;
    public string _porteName;
    // Start is called before the first frame update
    void Start()
    {
        _porte = GetComponent<GameObject>();
        _serure = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.CompareTag(_porteName))
        {
            _porte.transform.Translate(_porte.transform.position);
        }
    }

}

