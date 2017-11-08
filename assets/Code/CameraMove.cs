using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
		
	//GameObject backGround;
	GameObject player;
	//GameObject MainCam;
	float firstCamPosx;

	// Use this for initialization
	void Start () {
		Debug.Log ("Calling the camera start");
		//backGround = GameObject.Find ("bg1");
		player = GameObject.Find ("bunnyLarry");
		firstCamPosx = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Calling the camera methods");

		if(this.transform.position.y < player.transform.position.y)
			transform.position = new Vector3(firstCamPosx,player.transform.position.y,-2);

	}
}
