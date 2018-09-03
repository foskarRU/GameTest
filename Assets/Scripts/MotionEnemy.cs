using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionEnemy : MonoBehaviour {

    public double increment = 0.05;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Vector2 newCoor = new Vector2(Math.Sin(increment), Math.Sin(increment));
        Vector2 currentCoor = transform.localPosition;
        currentCoor.x += (float)Math.Sin(increment);
        currentCoor.y += (float)Math.Cos(increment);
        transform.localPosition = currentCoor;
    }
}
