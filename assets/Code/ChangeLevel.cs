using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour
{

    public int distance;
    public int startVal;
    public bool beat;

   
    private GameObject GameControlObj = GameObject.Find("GameControlObj");
    private GameControl gameControl;
   
   

    // Use this for initialization 
    void Start()
    {
        startVal = (int) transform.position.y;
        distance = 0;
        gameControl = GameControlObj.GetComponent<GameControl>();
        beat = false;

    }

    // Update is called once per frame 
    void Update()
    {
        distance = (int)transform.position.y - startVal;

        //need to determine what distances correspond to what level 
        if (distance <= 500)
        {
            Change();
            gameControl.level += 1;
            distance = 0;
        }

    }

    void Change()
    {
        Serialization.Load();

        if (gameControl.score > Serialization.maxScores[gameControl.level])
        {
            Serialization.maxScores[gameControl.level] = gameControl.score;
            gameControl.beat[gameControl.level] = true;
            gameControl.prevScores[gameControl.level] = gameControl.score;
            beat = true;
            
        }

        Serialization.Save();

    }
    void OnGUI()
    {
        if(beat)
            GUI.Label(new Rect(500, 100, 100, 200), "New High Score!!!!");
        beat = false;
        wait();
        //make fade out
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3.0f);
    }



}
