using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //add this line

public class ScoreCount : MonoBehaviour {
// create ScriptManager and attach this script

	public static float gscore = 0f;
	public static bool winStatus = true;

	public Text scoreText;
	public GameObject resultBtn;
	public GameObject youWin;
	public GameObject youLose;
	public GameObject returnMain;

    void Update(){
		scoreText.text = "Boxes Retrieved: " + gscore + "/5";
		if (gscore >= 5f) {

            resultBtn.SetActive(true);
			returnMain.SetActive(true);
			youWin.SetActive (true);
		}
		if (winStatus == false) 
		{
            //the enemy touches the player
            resultBtn.SetActive(true);
            returnMain.SetActive(true);
            youLose.SetActive (true);
        }
    }
}
