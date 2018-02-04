using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogMovement2 : MonoBehaviour
{
    public Transform image;
    public bool flag = true;
    public float count = 0f;
    public float moveSpeed = -0.1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count < 75)
        {
            count++;
                image.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                image.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        }
        else
        {
            moveSpeed *= -1;
            count = 0f;
        }
    }
}
