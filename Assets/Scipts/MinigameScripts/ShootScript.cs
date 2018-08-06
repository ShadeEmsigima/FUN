using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * select [CHECK]
 * set bullet [CHECK]
 * spawn bullet [CHECK]
 * shoot bullet [CHECK]
 * destroy bullet (mayeb)
 */

public class ShootScript : MonoBehaviour {

    private GameObject selectedObject;
    private GameObject currentAmmo;
    private Transform bulletTransform;
    private Rigidbody rb;

    public GameObject bulletStick;
    public GameObject bulletCross;
    public GameObject bulletMuf;
    public GameObject bulletDo;
    public GameObject bulletMo;
    public Camera fpsCam;
    public static float range = 100f;
    public float impactForce;

    // Use this for initialization
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E)) //pick something up
        {
            Debug.Log("Pressed E");
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)) // if u hit anything
            {
                selectedObject = hit.collider.gameObject;

                if (selectedObject.tag == "Stick")
                {
                    //Instantiate(bulletStick, hand.transform);
                    currentAmmo = bulletStick;
                    Debug.Log("You picked up the stickbread!");
                }

                if (selectedObject.tag == "Cross")
                {
                    //Instantiate(bulletCross, hand.transform);
                    currentAmmo = bulletCross;
                    Debug.Log("You picked up the croissant!");
                }

                if (selectedObject.tag == "Muf")
                {
                    //Instantiate(bulletMuf, hand.transform);
                    currentAmmo = bulletMuf;
                    Debug.Log("You picked up the muffin!");
                }

                if (selectedObject.tag == "Do")
                {
                    //Instantiate(bulletDo, hand.transform);
                    currentAmmo = bulletDo;
                    Debug.Log("You picked up the doughnut!");
                }

                if (selectedObject.tag == "Mo")
                {
                    //Instantiate(bulletMo, hand.transform);
                    currentAmmo = bulletMo;
                    Debug.Log("You picked up the mochi!");
                }
            }
        }

        if (Input.GetMouseButtonDown(0)) {
            GameObject bullet = Instantiate(currentAmmo, fpsCam.transform.position, Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(fpsCam.transform.forward * impactForce);
            Destroy(bullet, 3f);
        }
    }


}
