using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
    public void OnNewGameClick(string level)
    {
       Application.LoadLevel(level);
    }

    public void OnExitGameClick()
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

}
