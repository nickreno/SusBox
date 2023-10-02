using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{

    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;

    

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
    }

    public void Drop()
    {
        this.objectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
    }

    private void FixedUpdate()
    {

        if (objectGrabPointTransform != null)
        {
            objectRigidbody.MovePosition(objectGrabPointTransform.position);
        }
    }

    private void OnTriggerEnter(Collider amogusCollider)
    {
        if (amogusCollider.gameObject.tag == "DeliveryPoint")
        {

            ScoreCount.gscore += 1f; //increment score 
            Destroy(gameObject);
            RandomSpawner.killedEnemy = true;
            DeliveryNoise.cueNoise = true;

        }
    }


}




//      Grab() and Drop() Modeled off of Code Monkey's Unity scripts 