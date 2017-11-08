using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class HomeScreen : MonoBehaviour 
{
	public string CurrentMenu;
    public int maxLevel;
	
	void Start()
	{
        Debug.Log("in here");
		CurrentMenu = "Main";
	}
	
	void OnGUI()
	{
		if (CurrentMenu == "Main")
			Menu_Main ();

		if (CurrentMenu == "Play")
			Menu_Play ();
		
		if (CurrentMenu == "Credits")
			Menu_Credits ();
	}
	
	public void NavGate (string nextmenu)
	{
		CurrentMenu = nextmenu;
	}
	
	private void Menu_Main()
	{
		if (GUI.Button (new Rect (10, 10, 200, 50), "Play")) 
		{
			NavGate ("Play");
		}
		
		if (GUI.Button (new Rect (10, 70, 200, 50), "Credits")) 
		{
			NavGate ("Credits");
		}
		if (GUI.Button (new Rect (10, 130, 200, 50), "Tutorial")) 
		{
			Application.LoadLevel("Tutorial");
		}
        if (GUI.Button(new Rect(10, 190, 200, 50), "Exit"))
        {
            Application.Quit();
        }
    }

	private void Menu_Play()
	{
        GUI.Label(new Rect(10, 10, 200, 50), "Choose Level");

        if (GUI.Button (new Rect (10, 190, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}

        Serialization.Load();
        maxLevel = Serialization.level;

        GameObject GameControlObj = GameObject.Find("GameControlObj");
        GameControl gameControl = GameControlObj.GetComponent<GameControl>();


        if (GUI.Button(new Rect(10, 30, 200, 20), "Level 0")) 
		{
			Application.LoadLevel("First Scene");
		}
        if(maxLevel >= 10)
        {
            if (GUI.Button(new Rect(10, 60, 200, 20), "Level 10"))
            {
                gameControl.level = 10;
                Application.LoadLevel("First Scene");
            }
        }
        if (maxLevel >= 20)
        {
            if (GUI.Button(new Rect(10, 90, 200, 20), "Level 20"))
            {
                gameControl.level = 20;
                Application.LoadLevel("First Scene");
            }
        }
    }
	
	private void Menu_Credits()
	{
		if (GUI.Button (new Rect (10, 10, 200, 50), "Back")) 
		{
			NavGate ("Main");
		}
	}




}

