using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeStart : MonoBehaviour
{

    public string levelToLoad;
    public GameObject menuBtn;
    public GameObject menuBtnText;

    public static GameObject switchLevel;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock")
        {
            LoadTheGameLevel();
        }
    }

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
