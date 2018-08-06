using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject disc;
    public float discRotationSpeed;
    public static int score;

    public List<GameObject> spawnedCustomers;
    public GameObject[] customerTypes;
    public GameObject[] spawnSpots;

    void Start () {
        score = 0;
        discRotationSpeed = 2f;
        SpawnNew();
	}
	

	void Update () {
        disc.transform.Rotate(Vector3.up * discRotationSpeed);

        
    }

    void SpawnNew() {//make a random new customer at a random spawn spot
        GameObject child = Instantiate(customerTypes[Random.Range(0, 8)], spawnSpots[Random.Range(0, 8)].transform.position, Quaternion.identity);
        child.transform.parent = disc.transform;//make sure it sticks to that one spot!
        Debug.Log("Hello World! Im a new costumer.");
    }

}
