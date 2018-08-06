using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes the self turn towards player cam

public class EnemyScript : MonoBehaviour {

    public GameObject moveTarget;

	void Start () {
        Debug.Log("Enemy script up and running!");
	}
	

	void Update ()
    {
        transform.LookAt(moveTarget.transform);
    }
}
