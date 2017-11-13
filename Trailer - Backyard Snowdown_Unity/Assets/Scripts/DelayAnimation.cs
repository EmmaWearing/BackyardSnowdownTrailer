using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnimation : MonoBehaviour {

	public float timeToAnimation;

	private bool hasPlayed=false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (timeToAnimation < Time.time && !hasPlayed) {
			BeginAnimation ();
			hasPlayed=true;
		}
	}

	public void BeginAnimation(){
		GetComponent<Animator> ().SetTrigger ("StartAnimation");
	}
}
