using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetection : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE key was pressed");
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("LEFT CLICK was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R key was pressed");
        }
    }
}
