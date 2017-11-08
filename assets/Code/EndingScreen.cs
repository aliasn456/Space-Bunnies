using UnityEngine;
using System.Collections;

public class EndingScreen : MonoBehaviour {

    public string CurrentMenu;
    public string level;
    public int maxScoreLevel;
    private GameObject GameControlObj;
    private GameControl gameControl;



    // Use this for initialization
    void Start () {
		GameControlObj = GameObject.Find("GameControlObj");
        gameControl = GameControlObj.GetComponent<GameControl>();
        level = "" + gameControl.level;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(100, 113, 200, 50), "<size=14>" + gameControl.level + "</size>");

        if (GUI.Button(new Rect(100, 200, 200, 20), "Home"))
        {
            Application.LoadLevel("Home Scene");
        }

    }


    void ShowScores()
    {
       //show all scores in the array and tell if it best the prev scores

    }

}
