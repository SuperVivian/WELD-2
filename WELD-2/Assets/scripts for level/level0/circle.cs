using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour {
    public GameObject cpoint;//圆心
    public Vector3 anglevelocity;//x=0,y=0,z>0
    private Vector3 dirr;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        dirr = new Vector3(0,0,0);
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Theresult();
    }

    void Theresult()
    {
        dirr = this.transform.position - cpoint.transform.position;
        rb.velocity = Vector3.Cross(dirr.normalized,anglevelocity);
    }
}
