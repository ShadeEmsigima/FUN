using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* this sript changes the image of the crosshair depending on the currentBullet 
 */
public class ChangeCrosshair : MonoBehaviour {

    private int currentBullet;

    public GUIElement crosshairImage;
   
	void Update () {
        currentBullet = GunScript.currentBullet;

        if (currentBullet == 0) {
            
        }
    }
}
