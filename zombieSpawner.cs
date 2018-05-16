using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawner : MonoBehaviour {
	public Transform zombie;
	Transform tr;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn",4f,5f);
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawn(){
		Instantiate (zombie,tr.position, tr.rotation);
	}
}
