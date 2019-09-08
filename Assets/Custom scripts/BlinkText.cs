using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BlinkText : MonoBehaviour {

    private GameObject beginGame;
    private int framecounter = 0;

	void Start () {
        beginGame = GameObject.Find("BeginGameText");
	}
	
	void Update () {
        framecounter += 1;
        if(framecounter > 40) {
            framecounter = 0;
            beginGame.SetActive(false);
        } else {
            beginGame.SetActive(true);
        }
    }
}
