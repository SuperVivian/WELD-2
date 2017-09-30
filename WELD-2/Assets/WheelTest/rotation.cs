using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    Rigidbody thisOBj;

    public Vector3 a; 

    // Use this for initialization
    void Start () {

        thisOBj = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {


        thisOBj.angularVelocity = a;


	}
}
