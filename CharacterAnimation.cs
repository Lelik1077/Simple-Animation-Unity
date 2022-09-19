using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {

	private Animator animator;

	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	
	void Update () 
	{
		if (Input.GetKey (KeyCode.W)) {
				animator.GetComponent<Animator>().SetBool ("isWalking", true);
			} if(Input.GetKeyUp(KeyCode.W)) {animator.GetComponent<Animator>().SetBool ("isWalking", false);
			}
			if (Input.GetKey (KeyCode.S)) {
				animator.GetComponent<Animator>().SetBool ("isWalking", true);
			} if(Input.GetKeyUp(KeyCode.S)) {animator.GetComponent<Animator>().SetBool ("isWalking", false);
			}
			if (Input.GetKey (KeyCode.A)) {
				animator.GetComponent<Animator>().SetBool ("isWalking", true);
			} if(Input.GetKeyUp(KeyCode.A)) {animator.GetComponent<Animator>().SetBool ("isWalking", false);
			}
			if (Input.GetKey (KeyCode.D)) {
				animator.GetComponent<Animator>().SetBool ("isWalking", true);
			} if(Input.GetKeyUp(KeyCode.D)) {animator.GetComponent<Animator>().SetBool ("isWalking", false);
			}

	}
}
