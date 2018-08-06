using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondShootScript : MonoBehaviour
{
    public Camera camToShootFrom;
    public GameObject bullet;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(camToShootFrom.transform.position, camToShootFrom.transform.forward, out hit))
            {
                Debug.Log("Hit " + hit.collider.name);
            }
        }
    }
}
