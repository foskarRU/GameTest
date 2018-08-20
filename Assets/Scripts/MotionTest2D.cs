using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionTest2D : MonoBehaviour {
    public Camera cam;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.x>-2.8 && mousePos.y >-4 && mousePos.x<2.8 && mousePos.y<4)
                this.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
        }
	}
}
