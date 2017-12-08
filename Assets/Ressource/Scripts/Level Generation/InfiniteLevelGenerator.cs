using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteLevelGenerator : MonoBehaviour {
    public GameObject currentGround;
    public Transform generationPoint;
    public float distanceBetween;
    public GameObject[] level_elements = new GameObject[0];

    private Transform EBlock;
    private Transform BBlock;
    private System.Random random;

    // Use this for initialization
    void Start()
    {
        random = new System.Random();
    }
    //BBlock
    //EBlock
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            EBlock = currentGround.transform.Find("EBlock");
            int index = random.Next(0, level_elements.Length-1);
            currentGround = level_elements[index];

            BBlock = currentGround.transform.Find("BBlock");

            //Vector3 position = new Vector3(currentGround.transform.position.x + (EBlock.transform.position.x - BBlock.transform.position.x), currentGround.transform.position.y + (EBlock.transform.position.y - BBlock.transform.position.y), 0.0f);
            float deltaX = currentGround.transform.position.x - BBlock.transform.position.x;
            float deltaY = currentGround.transform.position.y - BBlock.transform.position.y;
            Debug.Log("1  " + currentGround.transform.position.x + "   -   " + BBlock.transform.position.x + "   =     " + deltaX);
            Debug.Log("2  " + EBlock.position.x + "   +   " + deltaX + "   =     " + (EBlock.position.x + deltaX));

            Vector3 position = new Vector3(EBlock.position.x + deltaX, EBlock.position.y + deltaY, 0.0f);

            float groundWidth = currentGround.transform.Find("FallTrigger").GetComponent<BoxCollider2D>().size.x;
            transform.position = new Vector3(generationPoint.transform.position.x + groundWidth, generationPoint.transform.position.y, generationPoint.transform.position.z);

            Instantiate(currentGround, position, transform.rotation);
        }
    }
}
