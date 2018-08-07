using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodWastedScript : MonoBehaviour {

    public GameObject foodTarget;
    private int foodWasted;
    private Text foodWastedText;

    void Update () {
        foodWasted = foodTarget.GetComponent<ShootScript>().foodWasted;
        gameObject.GetComponent<Text>().text = "Food thrown: " + foodWasted.ToString();
    }
}
    