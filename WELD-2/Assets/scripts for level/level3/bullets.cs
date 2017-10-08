using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour {

    private Vector3 movement;
    public float Speed;
    public Vector3 dirr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movement = dirr * Speed * Time.deltaTime;
        transform.position = transform.position + movement;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            return;

        if (other.gameObject.layer == 8)
            Destroy(this);
    }
}
