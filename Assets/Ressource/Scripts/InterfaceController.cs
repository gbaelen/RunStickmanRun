using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController : MonoBehaviour {
    static public bool isHammerSelected;
    static public bool isShieldSelected;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotspot = Vector2.zero;

    public Texture2D hammer;
    public Texture2D shield;

    public void OnHammerDown()
    {
        if (!isHammerSelected)
        {
            isHammerSelected = true;
            isShieldSelected = false;
            Cursor.SetCursor(hammer, hotspot, CursorMode.ForceSoftware);
        }
        else
        {
            Cursor.SetCursor(null, hotspot, CursorMode.Auto);
            isHammerSelected = false;
        }
    }
    public void OnShieldDown()
    {
        if (!isShieldSelected)
        {
            isShieldSelected = true;
            isHammerSelected = false;
            Cursor.SetCursor(shield, hotspot, CursorMode.ForceSoftware);
            
        }
        else
        {
            Cursor.SetCursor(null, hotspot, CursorMode.Auto);
            isShieldSelected = false;
        }
    }
    // Use this for initialization
    void Start () {
        isHammerSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

   
}
