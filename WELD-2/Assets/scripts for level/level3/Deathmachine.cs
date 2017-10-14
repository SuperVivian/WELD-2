using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathmachine : MonoBehaviour {
    public float velocity;
    public bool isgo;
    public Script4change player;

	// Use this for initialization
	void Start () {
        isgo = false;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(transform.position.x-velocity*0.8f*Time.deltaTime,transform.position.y,transform.position.z);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stair")
            other.gameObject.SetActive(false);
        if (other.tag == "Player")
            player.health = 0.0f;

    }
}
