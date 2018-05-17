using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animycontroller : MonoBehaviour {
	Animator animm;
	public Transform camera;
	NavMeshAgent nav;
	CapsuleCollider coll;
	Rigidbody cloning;

	void Start () {
		nav=GetComponent<NavMeshAgent>();
		animm=GetComponent<Animator>();
		coll=GetComponent<CapsuleCollider>();

	}
	void Update () {
		nav.SetDestination (camera.position);
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag=="bullet") {
			animm.SetFloat ("dead", 1.5f);
			nav.enabled = false;
			coll.enabled = false;
		}

	}


		
}
