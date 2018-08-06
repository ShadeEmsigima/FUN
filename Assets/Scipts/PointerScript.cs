using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//I didnt know this without the YTers help

//Link to vid that helped me: https://www.youtube.com/watch?v=m3S-X-ZESu0

public class PointerScript : MonoBehaviour {

    private float range;
    public Camera camToShootFrom;
    public Text pointerText;


	void Start ()
    {
        Debug.Log("Pointer script up and running!");
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(camToShootFrom.transform.position, camToShootFrom.transform.forward, out hit, range))
        {
            Debug.Log("You are looking at " + hit.collider.gameObject.name);
            //if the thing u look at is at layer NUMBER 8 (not string name)
            if (hit.collider.gameObject.layer == 8)
            {
                pointerText.text = "'E' to pick up";
                Debug.Log("Text just updated");
            }
            
        }

    }
}
