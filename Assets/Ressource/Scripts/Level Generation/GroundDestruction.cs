using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestruction : MonoBehaviour {
    public GameObject groundDestructionPoint;
	// Use this for initialization
	void Start () {
        groundDestructionPoint = GameObject.Find("LevelDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < groundDestructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
	}
}
