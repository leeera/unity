using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	//float h;
	float f;
	float m;
	public Rigidbody mainObject;
	public Transform target;
	Rigidbody clone;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		v=Input.GetAxis("Vertical");
		//h=Input.GetAxis("Horizontal");
		f = Input.GetAxis ("Fire1");
		m = Input.GetAxis ("Mouse X");
		//Vector3 force = new Vector3 (0, 0, v);
		rb.AddForce (tr.forward * v *100f);
		Vector3 rotation = new Vector3 (0, m, 0);
		tr.Rotate (rotation*5f);

		if (f > 0) {
			clone = Instantiate (mainObject, target.position, target.rotation);
			clone.AddForce (tr.forward * 5000f);
		}
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag =="enemy") {
			Destroy (gameObject);
		}

	}


}
