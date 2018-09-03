using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject shell;
    private float timeFlag = 0;
    private float pause = 1f;
    private float speed = 5f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if ((timeFlag + pause) <= Time.time)
        {
            Vector3 coor = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, -9.1f);
            GameObject obj = Instantiate(shell, coor, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            timeFlag = Time.time;
        }
    }
}
