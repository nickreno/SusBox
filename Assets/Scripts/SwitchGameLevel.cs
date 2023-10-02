using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGameLevel : MonoBehaviour
{
    public string levelToLoad;
    public GameObject menuBtn;
    public GameObject menuBtnText;

    public void LoadTheGameLevel()
    {
        if (levelToLoad == "Assignment1_MainMenuScene")
        {
            ScoreCount.gscore = 0;
            menuBtn.SetActive(false);
            menuBtnText.SetActive(false);
            ScoreCount.winStatus = true;
        }

        Application.LoadLevel(levelToLoad);
    }


}
