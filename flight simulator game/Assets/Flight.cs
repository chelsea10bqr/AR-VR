using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public float speed = 60.0f;

    // Use this for initialization
    void Start()
    {
        Debug.Log("plane pilot script added to:" + gameObject.name);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;


        if (Input.GetKeyDown(KeyCode.K))
        {
            speed -=  10.0f;
            if (speed < 30.0f)
            {
                speed = 35.0f;
            };

        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            speed +=  10.0f;
            if (speed > 140.0f)
            {
                speed = 140.0f;
            }
        }






        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        float height = Terrain.activeTerrain.SampleHeight(transform.position);

        if (height > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, height, transform.position.z);
        }

    }
} 
 