using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerScript : MonoBehaviour {

    public GameObject target;
    public string myOrder;

    private void Start()
    {
        target.GetComponent<SpawnerScript>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == myOrder) {
            Destroy(gameObject);
            target.GetComponent<SpawnerScript>().spawnedCustomers--;
            target.GetComponent<SpawnerScript>().score++; //SpawnerScript.score += 1;
            Debug.Log("You succesfully delivered the order! Your score is " + target.GetComponent<SpawnerScript>().score);
        }
    }
}
