using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    //bool handInuse = false;

    private ObjectGrabbable objectGrabbable;

    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.tag == "Enemy")
        {
            ScoreCount.winStatus = false;

            //screen you lose comes up, button to go to main menu
            //at main menu, you will be prepped to start.
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (objectGrabbable == null)
            {
                float pickupDistance = 10f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance))
                    if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                    {
                        objectGrabbable.Grab(objectGrabPointTransform);
                    }
            } else
            {
                objectGrabbable.Drop();
                objectGrabbable = null;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }

    

}
