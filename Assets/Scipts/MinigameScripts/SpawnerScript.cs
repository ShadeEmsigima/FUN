using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject disc;
    private float discRotationSpeed;
    public int score;

    //public List<GameObject> spawnedCustomers;
    public int spawnedCustomers;
    public GameObject[] customerTypes;
    public GameObject[] spawnSpots;
    private int customerAmount = 1;

    void Start () {
        score = 0;
	}
	

	void Update () {
        disc.transform.Rotate(Vector3.up * discRotationSpeed);

        //Keeping track of the player's skils/difficulty level


        if (score <= 0) {
            discRotationSpeed = 0.5f;
           customerAmount = 1;
        }

        else if (score >= 3 && score <= 5)
        {
            discRotationSpeed = 1f;
            customerAmount = 2;
            
        }

        else if (score >= 6 && score <= 8)
        {
            discRotationSpeed = 1f;
            customerAmount = 3;

        }

        if (spawnedCustomers < customerAmount)
        {
            SpawnNew();
        }
    
    }

    void SpawnNew() {//make a random new customer at a random spawn spot
        GameObject child = Instantiate(customerTypes[Random.Range(0, 4)], spawnSpots[Random.Range(0, 7)].transform.position, Quaternion.identity);
        child.transform.parent = disc.transform;//make sure it sticks to that one spot!
        //spawnedCustomers.Add(child);
        spawnedCustomers += 1;
        Debug.Log("Hello World, Im a new customer!");
    }

}
