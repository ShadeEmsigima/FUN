using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// In dit script veranderd de grote van de kat en word er een geluid afgespeeld
//source: Unity Documentation

[RequireComponent(typeof(AudioSource))]

public class EatingCat : MonoBehaviour {


    public AudioClip[] miauws;
    private int foodCount;



    void Start () {
        foodCount = 0;
        Debug.Log("Eating cat script up and running!");
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            if (foodCount < 10)
            {
                // Widen the object by 0.1
                transform.localScale += new Vector3(0.5F, 0.5F, 0.5F);
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = miauws[0];
                audio.Play();
                Destroy(other.gameObject);
                foodCount += 1;
                Debug.Log("The cat likes the food!");
            }

            else
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = miauws[1];
                audio.Play();
                Debug.Log("Cat is full!");
            }

        }
    }
}
