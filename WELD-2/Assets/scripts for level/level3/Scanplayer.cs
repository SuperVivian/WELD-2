using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanplayer : MonoBehaviour {
    public GameObject machinegun1;
    public float deadline;
    public float V;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            float xchange = (other.gameObject.transform.position - machinegun1.transform.position).x /100;
            machinegun1.transform.position = new Vector3(machinegun1.transform.position.x+xchange*V*Time.deltaTime,machinegun1.transform.position.y,machinegun1.transform.position.z);
            
        }
    }
}
