﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute : MonoBehaviour {

    public Dammage pic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("runner"))
        {
            GetComponentInParent<Rigidbody2D>().constraints = (RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation);
            pic.GetComponent<Dammage>().isBlockable = true;
        }


    }
}
