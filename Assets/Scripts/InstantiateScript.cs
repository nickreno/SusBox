using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public GameObject bouncyBall;

    private void Start()
    {
        Instantiate(bouncyBall, transform.position, transform.rotation);
    }

}
