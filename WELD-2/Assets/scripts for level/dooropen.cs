using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour {
    public float ddl;
    public float speed;
    public GameObject door;
    private bool open;
    private float h;
    private float v;
    private bool manison;
	// Use this for initialization
	void Start () {
        open = false;
        h = door.transform.position.y;
        v = 1.0f;
        manison = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (manison)
        {
            if (open)
            {
                door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - v * speed * 0.8f * Time.deltaTime, door.transform.position.z);
                if (door.transform.position.y <= (h - ddl))
                    v = 0.0f;
            }

            if (open == false)
            {
                door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + v * speed * 0.8f * Time.deltaTime, door.transform.position.z);
                if (door.transform.position.y >= h)
                {
                    v = 0.0f;
                    manison = false;
                }
            }
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            open = true;
            v = 1.0f;
            manison = true;
        }
           

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            open = false;
        }
    }

}
