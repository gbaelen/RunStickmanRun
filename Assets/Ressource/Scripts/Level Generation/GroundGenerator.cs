using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {
    public GameObject initialGround;
    public Transform generationPoint;
    public float distanceBetween;

    private float groundWidth;

	// Use this for initialization
	void Start () {
        groundWidth = initialGround.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, initialGround.transform.position.y, transform.position.z);
            Instantiate(initialGround, transform.position, transform.rotation);
        }
	}
}
