using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch1 : MonoBehaviour {
    public Vector3 position1;
    public Vector3 position2;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1" )
        {

        }
    }
}
