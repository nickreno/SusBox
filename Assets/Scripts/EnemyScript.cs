using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    int targetHealth = 10;
    public GameObject playerPerson;     //was datatype Transform (July 16)

    Renderer m_ObjectRenderer;

    void Start()
    {
        playerPerson = GameObject.Find("Player");

        Color baseColor = Random.ColorHSV();

        //have all monsters be random colors
        m_ObjectRenderer = GetComponent<Renderer>();
        m_ObjectRenderer.material.color = baseColor;

        GameObject childd = this.transform.GetChild(0).gameObject;
        childd.GetComponent<Renderer>().material.color = Color.cyan;

        GameObject childd2 = this.transform.GetChild(1).gameObject;
        childd2.GetComponent<Renderer>().material.color = baseColor;


    }

    void OnCollisionEnter(Collision colEnem)
    {
        if (colEnem.gameObject.tag == "Rock")
        {
            Debug.Log("Enemy Hit, reducing health");
            //ScoreCount.gscore += 1; //add score
            targetHealth--;
            
        }

        if (targetHealth == 0)
        {
            Destroy(gameObject);
            RandomSpawner.killedEnemy = true;
        }
        

    }
}
