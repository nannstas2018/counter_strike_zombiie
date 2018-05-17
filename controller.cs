using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	
	Rigidbody rb;
	public Rigidbody obj;
	Rigidbody clone;
	Transform tr;
	float v;
	float h;
	float f;
	float x;
	public Transform dulo;
	void Start () {
		rb = GetComponent<Rigidbody>();
		tr = GetComponent<Transform>();

	}
	

	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");

		f = Input.GetAxis ("Fire1");
		x= Input.GetAxis ("Mouse X");
		Vector3 rotation = new Vector3 (0, x, 0);
		rb.AddForce (tr.forward*v*200f);
		tr.Rotate (rotation*5f);
		if (f > 0) {
			clone=Instantiate (obj,dulo.position,dulo.rotation);
			clone.AddForce (tr.forward * 5000f);

	}
}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag=="animy") {
			Destroy (gameObject);
		}

	}

	


}
