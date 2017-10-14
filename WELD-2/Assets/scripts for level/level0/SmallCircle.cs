using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircle : MonoBehaviour {
    public GameObject stick;
    public float deadRotation;
    public  float startRotation;
    public float anlevelocity;
    private bool isup;
    private bool isdown;
    private bool isgo;
	// Use this for initialization
	void Start () {
       
        isup = true;
        isdown = false;
        isgo = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isgo)
        {
            if (isup)
            {
                stick.transform.Rotate(new Vector3(0, 0, anlevelocity * Time.deltaTime));
                if (stick.transform.eulerAngles.z >= deadRotation)
                {
                    isup = false;
                    isdown = true;
                    isgo = false;
                }
            }

            if (isdown)
            {
                stick.transform.Rotate(new Vector3(0,0,-anlevelocity*Time.deltaTime));
                if (stick.transform.eulerAngles.z <= startRotation)
                {
                    isup = true;
                    isdown = false;
                    isgo = false;
                }
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            isgo = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            isgo = false;
    }
}
