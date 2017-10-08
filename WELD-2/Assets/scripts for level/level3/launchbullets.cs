using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchbullets : MonoBehaviour {
    private RaycastHit hit;
    private Ray ray;
    public Vector3 raydirection;
    public bullets bullets;
    public float tiaozhengz;
    public float tiaozhengx;
    public float timer;
    private float nowtimer;

	// Use this for initialization
	void Start () {
		
        nowtimer = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        ray = new Ray(transform.position, raydirection);
        if (Physics.Raycast(ray, out hit))
        if (hit.rigidbody)
        {
                print(hit.transform.name);
                if (nowtimer >= timer)
                {
                    bullets clone;
                    clone = Instantiate(bullets,transform.position,transform.rotation);
                    clone.dirr = raydirection.normalized;
                    nowtimer = 0.0f;
                }
                else
                    nowtimer += Time.deltaTime;
        }
    }
}
