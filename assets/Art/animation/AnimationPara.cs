using UnityEngine;
using System.Collections;

public class AnimationPara : MonoBehaviour {

    Animator anim;
    PlayerController pc;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        pc = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
       
	}
}
