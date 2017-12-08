using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationPrinter : MonoBehaviour {
    public GameObject player;
    public TextMesh explanation;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("runner"))
        {
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            explanation.text = "This is the first obstacle of the game. \nTo pass it you can press the space \nbutton of the keyboard or swipe right \nwith your left hand to make the \nstickman jump";
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("runner"))
        {
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            explanation.text = "";
        }
    }

	// Use this for initialization
	void Start () {
        explanation.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
