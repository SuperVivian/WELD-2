using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour {
    public switchesss switches;
    private RaycastHit hit;
    public float windforce;
    public float windforcejudge;
 
    public float deadline;
    private Ray ray;
	// Use this for initialization
	void Start () {
        ray = new Ray(transform.position,transform.right);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (switches.isactive)
        {
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.name);
                if (hit.rigidbody)
                {
                    print(hit.transform.name);
                    hit.rigidbody.AddForce(transform.right * windforce);

                    if (hit.transform.position.y >= deadline)
                        hit.rigidbody.AddForce(-ray.direction * windforcejudge);
                }
            }
        }
	}
}
