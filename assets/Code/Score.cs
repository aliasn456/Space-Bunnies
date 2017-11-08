using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public float distance;
	public int startDis;
    public int score;

    private GameObject GameControlObj = GameObject.Find("GameControlObj");
    private GameControl gameControl;

    void Start() {
        startDis = (int) transform.position.y;
		distance = 0;
        gameControl = GameControlObj.GetComponent<GameControl>();
    }
	void Update() {
        distance = (int)transform.position.y - startDis;
        gameControl.score = score;
	}
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), "Score: " + distance.ToString());
	}
}
