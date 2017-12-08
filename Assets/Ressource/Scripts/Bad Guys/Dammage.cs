using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dammage : MonoBehaviour {
    public int dammage = 1;
    public bool isBlockable = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("runner"))
            collision.GetComponent<Running>().dammage(dammage);
    }

   
}
