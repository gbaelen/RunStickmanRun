using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCollider : MonoBehaviour {
    private Vector3 mouse;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouse.x, mouse.y, 5.0f);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bad Guy") && collision.GetComponent<Dammage>().isBlockable && InterfaceController.isShieldSelected)
            Destroy(collision.transform.parent.gameObject);
    }
}
