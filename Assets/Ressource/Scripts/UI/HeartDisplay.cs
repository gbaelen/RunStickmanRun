using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDisplay : MonoBehaviour {

    public GameObject heart1, heart2, heart3;
    private List<GameObject> hearts = new List<GameObject>();  
 
    // Use this for initialization
    void Start () {
        
        hearts.Add(heart1);
        hearts.Add(heart2);
        hearts.Add(heart3);
    }
	
	// Update is called once per frame
	void Update () {

	

        
	}

    public void minusHeart(int lifePoint) {
        if (lifePoint <= 0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            lifePoint = 0;
        }
        else if(lifePoint < 3)
        {
            for (int i = 2; i >= lifePoint ; i--)
            {
                hearts[i].SetActive(false);

            }
        }
        

    }
}
