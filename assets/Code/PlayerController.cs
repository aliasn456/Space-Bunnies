using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;

	public bool grounded;
	private bool dead;
	
	private bool doubleJump;
	private int counter;
	float lockPos = 0;

	
	
	
	void Start ()
	{
        grounded = true;
	}
	
	
	void Update ()
	{
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);
        
		if (grounded) 
        {
			doubleJump=false;
			string s = "Grounded";
			Debug.Log(s);
		}
		if (Input.GetKeyDown (KeyCode.Space) && grounded) 
        {
			string s = "Getting in here";
			Debug.Log(s);
			Jump();
			counter += 1;
			string c = "The counter is " + counter;
			Debug.Log(c);

		}
		if (Input.GetKeyDown (KeyCode.Space) && !doubleJump && !grounded) 
		{
			string s = "Not Grounded";
			Debug.Log(s);
			Jump();
			doubleJump=true;
		}
		
		if (Input.GetKey (KeyCode.D)) 
        {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKey (KeyCode.A)) 
        {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		
	}
	
	public void Jump()
    {
		//other way to
		//GetComponent<Rigidbody2D> ().AddForce (Vectoe2.up * jumpHeight);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		grounded = false;
	}
	void OnCollisionEnter2D(Collision2D other)
    {
		//Switch
		//Add points
		Debug.Log("Entering the collosion method");
		if(other.gameObject.tag == ("Ground") && transform.position.y > other.transform.position.y){
			grounded = true;
			Debug.Log("Entering the collosion if statement");
		}
			
		
		if(other.gameObject.tag == "Bottom")
        {
            Serialization.Load();
            int newLevel = Serialization.level;

            GameObject GameControlObj = GameObject.Find("GameControlObj");
            GameControl gameControl = GameControlObj.GetComponent<GameControl>();
            if(newLevel > gameControl.level)
            {
                Serialization.Save();
            }

            Application.LoadLevel("Game Over");
        }
           //SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
		
	}

}