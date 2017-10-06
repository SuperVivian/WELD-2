using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchesss : MonoBehaviour {
    public bool isactive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            isactive = true;
    }
}
