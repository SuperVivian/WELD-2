using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour {
    public switchesss isactive;
    private RaycastHit hit;
    public Vector3 thewind;
    public float deadline;
    private Ray ray;
	// Use this for initialization
	void Start () {
        ray = new Ray(thewind,new Vector3(thewind.x,thewind.y+10.0f,thewind.z));
	}
	
	// Update is called once per frame
	void Update () {
        if (isactive)
            if (Physics.Raycast(ray, out hit))
            {
                hit.rigidbody.AddForce(ray.direction * 0.8f);
                if (hit.transform.position.y >= deadline)
                    hit.rigidbody.AddForce(-ray.direction * 1.2f);
            }
	}
}
