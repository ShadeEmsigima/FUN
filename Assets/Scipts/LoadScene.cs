using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Dit script is volledig overgenomen uit een YT tutorial door Gamesplusjames: https://www.youtube.com/watch?v=aVErs6FNbvQ

public class LoadScene : MonoBehaviour {

    public string levelToLoad;

    private void Start()
    {
        Debug.Log("Loadlevel script up and running!");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1")
        {
            Debug.Log("Loading " + levelToLoad);
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
