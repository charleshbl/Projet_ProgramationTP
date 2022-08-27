using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Script : MonoBehaviour
{
    Light Light;
    // Start is called before the first frame update
    void Start()
    {
        Light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) { Light.enabled = false; }
        
    }
}
