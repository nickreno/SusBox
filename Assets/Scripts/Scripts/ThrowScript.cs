using UnityEngine;
using System.Collections;

public class ThrowScript : MonoBehaviour {
//attach this script to the FPS Controller and then drop the rock prefab to the rock_Prefab slot

	public GameObject rock_Prefab; //open the slot for rock prefab
	float rockSpeed = 20f; //rock Speed
	bool handOccupied = false;

	// Update is called once per frame
	void Update () {
		if(handOccupied == false)
		{
            if (Input.GetButtonDown("Fire1"))
            {
                Camera cam = Camera.main;
                GameObject thebullet = (GameObject)Instantiate(rock_Prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation); //throw the rock to the forward direction
                thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * rockSpeed, ForceMode.Impulse); //adding force to our rock
            }
        }
		
	}

}
