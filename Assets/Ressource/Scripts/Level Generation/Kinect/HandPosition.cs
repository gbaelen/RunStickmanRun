using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPosition : MonoBehaviour {
    private Vector3 mousePosition;
    // Use this for initialization
    void Start () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, -8.0f);
    }
	
	// Update is called once per frame
	void Update () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MouseControl.MouseMove(transform.position, null);
        Debug.Log(Input.mousePosition.x + " ---------- " + Input.mousePosition.y);
    }
}
