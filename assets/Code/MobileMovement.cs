using UnityEngine;
using System.Collections;

public class MobileMovement : MonoBehaviour {

    private float moveSpeed;
    private float jumpHeight;
    private bool grounded;

    // Use this for initialization
    void Start () {
        moveSpeed = 5;
        jumpHeight = 10;
        grounded = true;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 0);
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, 0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * moveSpeed;
    }

    public void Jump()
    {
        //other way to
        //GetComponent<Rigidbody2D> ().AddForce (Vectoe2.up * jumpHeight);
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        grounded = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Jump();
    }

 }
