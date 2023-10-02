using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryNoise : MonoBehaviour
{
    public AudioClip amongusNoise;
    AudioSource audioSource;

    public static bool cueNoise = false;

    void Update()
    {
        if (cueNoise == true)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(amongusNoise);      //FIXME audio won't play?
            cueNoise = false;
        }
    }
}
