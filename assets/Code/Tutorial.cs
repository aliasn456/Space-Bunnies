using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		if (GUI.Button (new Rect (10, 130, 200, 50), "Back")) 
		{
			Application.LoadLevel("Home Screen");
		}
	}
}
