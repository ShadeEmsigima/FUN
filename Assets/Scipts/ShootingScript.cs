using UnityEngine;

//Dit gehele script is overgenomen van Brackeys op YT: https://www.youtube.com/watch?v=THnivyG0Mvo&t=1s

public class ShootingScript : MonoBehaviour {

    public float damage = 10f;
    public static float range = 100f;
    //public GameObject bullet;
    public Camera camToShootFrom;
    public float impactForce = 100f;
    public float speed;
    public AudioClip[] playerSounds;

    private Transform prefabBullet;
    private AudioSource audio;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Throw();
        }
    }

    void Throw()
    {
        RaycastHit hit;
        if (Physics.Raycast(camToShootFrom.transform.position, camToShootFrom.transform.forward, out hit, range))
        {
            //if something has a rigid body, add force to it
            /*if (hit.rigidbody != null)
            {
                prefabBullet = hit.transform;
                if (hit.rigidbody.tag == "Food")
                {
                    Instantiate(prefabBullet, camToShootFrom.transform.position, Quaternion.identity);
                }
                    

                //poke your target!*/
            hit.rigidbody.AddForce(-hit.normal * impactForce);
        }    
    }
}
