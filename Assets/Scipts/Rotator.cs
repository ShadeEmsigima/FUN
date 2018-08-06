using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	void Update () {
        // Rotate the object around its local z axis at 1 degree per second
        transform.Rotate(Vector3.down * speed);
        // source: Unity Documentation Rotate
    }
}
