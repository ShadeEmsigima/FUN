using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public GameObject scoreTarget;
    private int score;
    private Text scoreText;

	void Update () {
        score = scoreTarget.GetComponent<SpawnerScript>().score;
        gameObject.GetComponent<Text>().text = "Score: " + score.ToString();
	}
}
