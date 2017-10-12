using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch1 : MonoBehaviour {
    public bool isactive1;

	// Use this for initialization
	void Start () {
        isactive1 = false;

	}
	
	// Update is called once per frame
	void Update () {


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            isactive1 = true;
    }

}
