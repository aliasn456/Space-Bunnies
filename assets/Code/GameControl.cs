using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    public int level;
    public int score;
    public bool[] beat = new bool[20];
    public int[] prevScores = new int[20];

    void Awake () {
	    if(control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnGUI()
    {
        GUI.Label(new Rect(500, 10, 100, 200), "Level: " + level);
    }

}


