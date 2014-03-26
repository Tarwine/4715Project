﻿using UnityEngine;
using System.Collections;

public class DebrisLevel1static: MonoBehaviour {
	public GameObject explosionEffect;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		//If this debris collided with the ship explode and destroy this debris
		if(other.gameObject.tag == "Ship" || other.gameObject.tag == "Player"){
			//Place the explosion in front of the ship by 3 units
			GameObject.Instantiate(explosionEffect, other.transform.position + Vector3.forward * 3, this.transform.rotation);
			GameObject.Destroy(this.gameObject);
			GameObject.Find("OVRCharacterFlying").GetComponent<FlyingControls>().damagePlayer();
		}
	}
}
