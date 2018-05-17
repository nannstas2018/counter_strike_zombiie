using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag=="thing") {
			Destroy (gameObject);
		}

	}

}
