using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationScript : MonoBehaviour
{
    public GameObject player;       //was datatype Transform (July 16)
    private NavMeshAgent agent;
    
    void Start()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = player.transform.position;        
    }
}
