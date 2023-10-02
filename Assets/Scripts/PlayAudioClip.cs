using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{
    public AudioClip myClip;
    AudioSource audioSource;

    private void Update()
    {
        audioSource = GetComponent<AudioSource>();

        if(Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(myClip);
        }    
    }
}
