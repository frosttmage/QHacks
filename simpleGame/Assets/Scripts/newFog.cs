using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newFog : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 1;
    
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(speed, 0, 0);
	}
}
