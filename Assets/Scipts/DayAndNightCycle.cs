using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script lets the sun rotate day n night

public class DayAndNightCycle : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * Time.deltaTime);
        // source: Unity Documentation Rotate
    }
}
