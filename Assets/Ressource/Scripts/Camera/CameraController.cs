using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        
    }

    void LateUpdate()
    {
        if(player.GetComponent<Running>().isAlive())
        transform.position = player.transform.position + offset;
    }
}