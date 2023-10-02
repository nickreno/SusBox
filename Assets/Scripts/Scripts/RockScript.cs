using UnityEngine;
using System.Collections;

public class RockScript : MonoBehaviour {
//attach this script to the rock Prefab

	float lifespan = 2.0f; //how long the rock will stay in the game scene
    public GameObject enemy_Prefab;

    // Update is called once per frame
    void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0) {
			Explode();
		}
	}

	//rock will be directly destroyed if it collides with target
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Enemy") {
			Destroy(gameObject);
            //GameObject newEnemy = (GameObject)Instantiate(enemy_Prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation); //throw the rock to the forward direction

        }
    }

	//Explode function to destroy rock
	void Explode() {
		Destroy(gameObject);
	}
}
