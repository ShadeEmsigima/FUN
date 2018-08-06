using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public static int bread;

	void Start () {
        bread = 0;
	}

    void AddBread()
    {
        bread += 1;
        Debug.Log("You currently have " + bread + "bread!");
    }

    void SubtractBread()
    {
        bread -= 1;
        Debug.Log("You currently have " + bread + "bread!");
    }

}
