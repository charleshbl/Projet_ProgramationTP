using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Playerscript : MonoBehaviour
{
    //déclaration des variables : Texte pour afficher le score et le temps de jeu, plus le compte a rebours 
    //déclaration des variables : Cash et texte de fin.
    private int _score;
    public GameObject _joueur;
    public TextMeshProUGUI Cash;
    public TextMeshProUGUI chrono;
    public TextMeshProUGUI fin;
    public GameObject textefin;
    float starttime;
    Time time;

    
    void Start()
    {
        textefin.SetActive(false);
        starttime = Time.realtimeSinceStartup;
        _score = 0;
        _joueur.GetComponent<GameObject>().SetActive(true);
    }

    // Assigner le temps en minutes et en secondes - L'afficher en lettres - Mettre fin au temps et afficher au joueur que la partie est finie plus le score. 
    void Update()
    {
        float t = Time.realtimeSinceStartup - starttime;
        string m = ((int)t / 60).ToString();
        string s = ((int)t % 60).ToString();
        Cash.text = "CASH :" + _score.ToString();
        chrono.text = m + ":" + s + "\n Fin : 3:00";
        if (m == "3")
        {
            Cash.text = "";
            chrono.text = "";
            textefin.SetActive(true);
            fin.text = "vous avez fini \n avec : " + _score.ToString() + " en Or !";

        }

    }
    //Déclaration des différentes valeurs des pieces de monnaies collectés, et les condtions avec lesquelles les pieces réagissent 
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
