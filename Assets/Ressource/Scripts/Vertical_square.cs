using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical_square : MonoBehaviour {

    public Rigidbody2D rb;
    public GameObject axe;
    private Vector3 mousePosition;
    private bool isHover;
    private bool moveX;
    private bool moveY;
    private float lastX;
    private float lastY;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveX = false;
        moveY = false;
    }

    private void OnMouseEnter()
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

    private void OnCollisionEnter(Collision collision)
    {
        moveX = false;
        moveY = false;

        if (moveX)
        {
            rb.MovePosition(new Vector3(lastX, transform.position.y, transform.position.z));
        }
        if (moveY)
        {
            rb.MovePosition(new Vector3(transform.position.x, lastY, transform.position.z));
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (moveY)
        {
            rb.MovePosition(new Vector3(transform.position.x, lastY, transform.position.z));
        }
        if (moveX)
        {
            rb.MovePosition(new Vector3(lastX, transform.position.y, transform.position.z));
        }    
    }

    private void OnCollisionExit(Collision collision)
    {
        if (axe.transform.eulerAngles.z == 90)
        {
            moveX = true;
        }
        if (axe.transform.eulerAngles.z == 0)
        {
            moveY = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isHover)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if (moveY)
            {
                lastY = transform.position.y;
                transform.position = new Vector2(transform.position.x, mousePosition.y);
            }
            if (moveX)
            {
                lastX = transform.position.x;
                transform.position = new Vector2(mousePosition.x, transform.position.y);
            }
        }
    }
}
