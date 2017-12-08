using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour {
    private Rigidbody2D rb;

    private bool grounded = false;
    public Transform groundCheck;
    private float groundRadius = 0.2f;
    public LayerMask Ground;

    public float moveSpeed;
    public float jumpForce;
    private bool doubleJump = false;

    private bool alive = true;
    private int lifePoint = 3;
    private bool invincible = false;
    public GameObject ui;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        if(alive)
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
            //rb.velocity = new Vector2(0, -1);
        }
        if (lifePoint <= 0)
            alive = false;

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, Ground);

        if (grounded)
            doubleJump = true;
        if (Input.GetKeyDown(KeyCode.Space) && grounded )
        {
            jump();
        }else if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            jump(jumpForce/2);
            doubleJump = false;
        }

        if (invincible) {

        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bad Guy"))
        {
            lifePoint--;
            StartCoroutine(afterDamage());
            jump();

        }
    }

    private void jump()
    {
        rb.AddForce( new Vector2(0.0f, jumpForce), ForceMode2D.Impulse);
    }

    private void jump(float jumpForce)
    {
        rb.AddForce(new Vector2(0.0f, jumpForce), ForceMode2D.Impulse);
    }

    public bool isAlive()
    {
        return alive;
    }

    private IEnumerator afterDamage()
    {

        ui.GetComponent<HeartDisplay>().minusHeart(lifePoint);
        GetComponent<Animator>().SetBool("invincible", true);
        Physics2D.IgnoreLayerCollision(9, 10, true);

        yield return new WaitForSeconds(1.5f);
        
        Physics2D.IgnoreLayerCollision(9, 10, false);
        GetComponent<Animator>().SetBool("invincible", false);
    }

    private void Blink()
    {
        RealBlink();
        
    }

    private IEnumerator RealBlink()
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().enabled = true;
    }

    public int getLifePoint() {
        return lifePoint;
    }
}
