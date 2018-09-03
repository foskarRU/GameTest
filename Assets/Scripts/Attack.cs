using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    Camera _cam;
    public GameObject enemy;
    private float timeFlag = 0;
    private float pause = 1f;
    // Use this for initialization
    void Start () {
        _cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if ((timeFlag + pause) <= Time.time)
        {
            Vector3 coor = new Vector3(-3.9f, 4.6f, -9f);
            GameObject obj = Instantiate(enemy, coor, Quaternion.identity);
            timeFlag = Time.time;
        }
    }
}
