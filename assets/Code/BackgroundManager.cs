using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {
	
	public float speed;
	public GameObject[] Backgrounds;
	public GameObject player;
    public GameObject border;
	public float high;
    public GameObject lowBack;
    public GameObject highBack;

	
	// Update is called once per frame
	void start(){
		/*player = GameObject.Find("bunnyLarry");
        border = GameObject.Find("border (1)");*/
        
        lowBack = Backgrounds[0];
        highBack = Backgrounds[1];
	}
    
	void Update () {
        
		for (int i = 0; i < Backgrounds.Length; i++) {
			Vector3 pos = Backgrounds[i].transform.position;
			pos.y -= speed;
            Backgrounds[i].transform.position = pos;
        }
                
        if(border.transform.position.y > highBack.transform.position.y - 10){
            Vector3 pos1 = lowBack.transform.position;
            pos1.y += high * 2;
            lowBack.transform.position = pos1;
            
            GameObject temp = lowBack;
            lowBack = highBack;
            highBack = temp;
            
        }
    }
    
}
