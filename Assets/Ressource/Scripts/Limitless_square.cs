using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitless_square : MonoBehaviour {
    public Rigidbody2D rb;
    public GameObject axe;
    public GameObject hand;

    private Vector3 mousePosition;
    private bool isHover;
    private bool moveX;
    private bool moveY;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("axe"))
        {
            rb = GetComponent<Rigidbody2D>();
            rb.gravityScale = 10.0f;
            moveX = false;
            moveY = false;
        }
    }

    private void OnMouseOver()
    {
        isHover = true;
        if (axe.transform.eulerAngles.z == 90)
            moveX = true;
        if (axe.transform.eulerAngles.z == 0)
            moveY = true;
    }

    private void OnMouseExit()
    {
        isHover = false;
        moveX = false;
        moveY = false;
    }

    // Use this for initialization
    void Start () {
        rb.gravityScale = 0.0f;
        moveX = false;
        moveY = false;
    }
	
	// Update is called once per frame
	void Update () {
        {
            if (isHover)
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (moveY)
                {
                    transform.position = new Vector3(transform.position.x, mousePosition.y, -0.14f);
                }
                if (moveX)
                {
                    transform.position = new Vector3(mousePosition.x, transform.position.y, -0.14f);
                }
            }
        }
    }
}
