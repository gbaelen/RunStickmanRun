using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    private Rigidbody2D rb;
    public float moveSpeed;
    public bool moving = false;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (moving)
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
                   
    }

    public void setMoving(bool moving, int moveSpeed) {
        this.moving = moving;
        this.moveSpeed = moveSpeed;
    }

    public void setMoving(bool moving)
    {
        this.moving = moving;
    }
}
