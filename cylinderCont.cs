using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cylinderCont : MonoBehaviour {
	NavMeshAgent nav;
	Animator anim;
	public Transform target;


	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	void Update () {
		nav.SetDestination (target.position);
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag =="bullet") {
			anim.SetFloat ("dead",0.5f);
			nav.enabled = false;

		}
	}

}
