using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanplayerdown : MonoBehaviour {
    public Deathmachine death;
    public float v;
    public float deadline;
    private bool isgo;
    private float star;
	// Use this for initialization
	void Start () {
        death.velocity = 0.0f;
        isgo = false;
        star = death.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (isgo)
        {
            death.velocity = -v;
            if (death.transform.position.x <= deadline)
            {
                death.velocity = v;
                if (death.transform.position.x >= star)
                {
                    death.velocity = 0.0f;
                    isgo = false;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            isgo = true;
      
    }


}
