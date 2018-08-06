using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// deze code is geheel gekopieerd en geplakt van de BPW les

public class PickUp : MonoBehaviour
{   
    public float range = 100f;
    public Camera camToShootFrom;
    public float impactForce = 30f;


    private GameObject uppickedObject; // in deze variable houd ik bij welk objetct ik opgepakt heb. 
    // In hte begin ook leeg want nog geen waarde.
    private Rigidbody uppickedRigidbody;

    void Start()
    {
        print("PickUp Script up and running!");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //if you press E
        {
            //if you are NOT holding anything:

            //pick it up
            if (uppickedObject == null)
            {
                // ik wil getal 1 acht posities naar links verschuiven op bit raster
                int layerMask = 1 << 8;
                RaycastHit hit;

                if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hit, 3f, layerMask))
                {
                    // vanaf origin mijzelf plus een stukje vooren + de richting van naar voren, met dit als beperkte afstand
                    // layers zorgen er in unity voor dat je alleen hit laat zien voor fruit dingen ofzo
                    // vertel raycast dat hij alleen dingen van uppickable layer mag pakken
                    // ik wil weten welk object ik oppak en loslaat, meevolgt?

                    // controleren of ie echt iets raakt door print
                    //print("Hit!");
                    uppickedObject = hit.collider.gameObject;
                    // hiermee pak je object die je uit je ...... geraycast hebt? Parent. Geef bij de transform aan wie parent is.
                    uppickedObject.transform.parent = transform; //hiermee vertel je dat zn parent een eigen transform is en altijd mee moet gaan met mijn transform


                    uppickedRigidbody = (Rigidbody)uppickedObject.GetComponent(typeof(Rigidbody));
                    uppickedRigidbody.isKinematic = true;
                    Debug.Log("You just picked up " + uppickedObject.name + "!");
                }
            }

            // drop it
            else
            {
                uppickedRigidbody.isKinematic = false; //Its no longer frozen
                uppickedRigidbody = null;
                // maar nu volgt hij je nogsteeds
                uppickedObject.transform.parent = null; //no longer in ur hand
                uppickedObject = null; // reset variable
                Debug.Log("You just dropped the thing!");
            }
            Debug.Log("Loop End");
        }
    }
}
