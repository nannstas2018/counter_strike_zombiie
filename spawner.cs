using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawner : MonoBehaviour {


	public GameObject zombie;
	GameObject clone;
	Transform place;
	void Start () {
		InvokeRepeating ("spawner1", 4f, 10f);
		place = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void spawner1(){
		clone = Instantiate (zombie,place.position,place.rotation);
		clone.GetComponent<NavMeshAgent> ().enabled = true;
		clone.GetComponent<CapsuleCollider> ().enabled = true;

	}

}
