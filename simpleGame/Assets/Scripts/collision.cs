using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

    public float lifelight = 0;
    public float speedfactor = 1;


    public GameObject hero;
    public SimplePlatformController controlPlayer;


    private void Start()
    {
        hero = GameObject.Find("hero");
        controlPlayer = hero.GetComponent<SimplePlatformController>();

    }

    // Use this for initialization
    void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.CompareTag ("barrier"))
        {
            
            Debug.Log(coll.gameObject.tag);
            Debug.Log("hit shadow");

            //transform.position = new Vector3(0f, 1.5f, 0f);
            
            //if (lifelight == 0)
            //{
            //    Debug.Log("Game Over");
            //}

            //else
            //{
            //    lifelight = lifelight - 1;
            //    Debug.Log("Lose Light");
            //}

        }

        if (coll.gameObject.CompareTag("light"))
        {
            Debug.Log(coll.gameObject.tag);
            Debug.Log("gain light");

            lifelight = lifelight + 1;

            controlPlayer.maxSpeed += speedfactor;
            Debug.Log("faster");


            if (lifelight == 5)
            {
                Debug.Log("Winner");   
            }
        }
    }
	
	
}
