using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{

    private int _score;
    public GameObject _joueur;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _joueur.GetComponent<GameObject>().SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit other)
    {

        if (other.gameObject.CompareTag("cash1"))
        {
            _score++;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("cash10"))
        {
            _score += 10;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("cash25"))
        {
            _score += 25;
            other.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("cash1"))
        {
            _score++;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("cash10"))
        {
            _score += 10;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("cash25"))
        {
            _score += 25;
            other.gameObject.SetActive(false);
        }
    }
    
     
}
