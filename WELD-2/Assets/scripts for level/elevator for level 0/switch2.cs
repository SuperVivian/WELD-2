using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch2 : MonoBehaviour {
    public bool isactive2; 


    void Start () {
        isactive2 = false;
    }
	
	// Update is called once per frame
	void Update () {


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            isactive2 = true;
    }



}
