using UnityEngine;

//Vrijwel het gehele script overgenomen van Brackeys: https://www.youtube.com/watch?v=THnivyG0Mvo

public class GunScript : MonoBehaviour
{
    //private GameObject currentBullet;
    private GameObject uppickedObject;
    public GameObject bulletStick;
    public GameObject bulletCross;
    public GameObject bulletMuf;
    public GameObject bulletDo;
    public GameObject bulletMo;
    public GameObject hand;
    public Camera fpsCam;

    public static int currentBullet;

    private void Start()
    {
        currentBullet = 0;
        // stickbread = 0, croissant = 1, muffin = 2, doughnut = 3, mochi = 4
    }
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            uppickedObject = null; //resets the object u had in ur hand
        }*/

        if (Input.GetKeyDown(KeyCode.E)) //pick something up
        {
            Debug.Log("Pressed E");
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
            {
                // make sure you replace the previous object the player's hand with current
                if (uppickedObject == null)
                {
                    uppickedObject = hit.collider.gameObject;

                    if (uppickedObject.tag == "Stick")
                    {
                        //Instantiate(bulletStick, hand.transform);
                        currentBullet = 0;
                        Debug.Log("You picked up the stickbread!");
                    }

                    if (uppickedObject.tag == "Cross")
                    {
                        //Instantiate(bulletCross, hand.transform);
                        currentBullet = 1;
                        Debug.Log("You picked up the croissant!");
                    }

                    if (uppickedObject.tag == "Muf")
                    {
                        //Instantiate(bulletMuf, hand.transform);
                        currentBullet = 2;
                        Debug.Log("You picked up the muffin!");
                    }

                    if (uppickedObject.tag == "Do")
                    {
                        //Instantiate(bulletDo, hand.transform);
                        currentBullet = 3;
                        Debug.Log("You picked up the doughnut!");
                    }

                    if (uppickedObject.tag == "Mo")
                    {
                        //Instantiate(bulletMo, hand.transform);
                        currentBullet = 4;
                        Debug.Log("You picked up the mochi!");
                    }
                }

            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.collider.tag);
        }
    }
}
