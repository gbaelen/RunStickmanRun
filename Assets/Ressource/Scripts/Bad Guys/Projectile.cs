using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    static public GameObject projectileToClone;
    public GameObject projectile;
    public int moveSpeed;
    private Vector3 position;
    private Quaternion rotation;
    public float fireRate = 3.5f;
	// Use this for initialization
	void Start () {
        projectileToClone = projectile;
        position = projectile.GetComponent<Transform>().position;
        rotation = projectile.GetComponent<Transform>().rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("runner"))
        {
            Debug.Log(collision.gameObject.name);
            projectile.GetComponent<Moving>().setMoving(true);
            InvokeRepeating("generateProjectile", fireRate, fireRate);
        }
            
             
    }

    private void generateProjectile()
    {
        projectile = Instantiate(projectileToClone, position, rotation);
        

    }
}
