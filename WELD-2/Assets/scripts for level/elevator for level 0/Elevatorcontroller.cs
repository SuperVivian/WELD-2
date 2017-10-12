using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevatorcontroller : MonoBehaviour {
    public Lands land;
    public Transform Land;
    public float velocity;
    public bool isgodownfirst;
    public float timer;

    private float v;
    private float t;

	// Use this for initialization
	void Start () {
        if (isgodownfirst)
            velocity = -velocity;
        v = 1.0f;
        t = timer;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
            if (land.isgo)
            {
                Land.position = new Vector3(Land.position.x, Land.position.y + v*velocity * 0.8f * Time.deltaTime, Land.position.z);
                if (Land.position.y <= land.miny || Land.position.y>=land.maxy)
                {
                    v = 0.0f;
                    timer -= 0.8f * Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        land.isgo = false;
                        velocity = -velocity;
                        timer = t;
                    v = 1.0f;
                    }
         
                }
            }
    
            
    }
}
