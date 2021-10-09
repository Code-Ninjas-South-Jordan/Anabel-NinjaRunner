using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    
    public Text scoreText;
    [Header("Starting Score")]
    public int score;
    
    public ParticleSystem Pickup;

    void Start()
    {
       
       Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        print("you are not normal ");
        if(other.gameObject.CompareTag("coin"))
        {
            score++;
            scoreText.text = "" + score;
            Destroy(other.gameObject);  
            Pickup.Play();
        }
    }
}
